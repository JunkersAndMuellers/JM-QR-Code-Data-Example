using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using JM.Tools;

namespace JMQRCodeDataExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            tbType.Text = "";
            tbName.Text = "";
            tbPieces.Text = "";
            tbWeight.Text = "";
            tbUnits.Text = "";
            tbArticleNo.Text = "";
            tbArticleDesc.Text = "";
            tbWeightPiece.Text = "";
            tbLength.Text = "";

            if (tbURL.Text.Contains("GetPiece?uid="))
            {
                // Single Piece Data
                tbType.Text = "JM-Piece ";
                PieceRecord JMPiece = GetPieceData(tbURL.Text);
                if (JMPiece != null)
                {
                    //
                    // write the JMPiece to your database server
                    //
                    tbType.Text = "JM-Piece " + JMPiece.PieceNo.ToString();
                    tbArticleNo.Text = JMPiece.ArticleNo;
                    tbArticleDesc.Text = JMPiece.ArticleDescription;
                    tbWeightPiece.Text = JMPiece.WeightBrut.ToString() + "/" + JMPiece.WeightNet.ToString() + " kg";
                    tbLength.Text = JMPiece.Brut.ToString() + "/" + JMPiece.Net.ToString() + " m";
                }
            }
            else
            {
                // Packing List Data
                tbType.Text = "JM-Packing list";
                PLRecord JMPackingList = GetPackingListData(tbURL.Text);
                if (JMPackingList != null)
                {
                    //
                    // write the JMPackingList to your database server
                    //
                    tbType.Text = "JM-Packing list No.:"+JMPackingList.PackinglistNo.ToString();
                    tbName.Text = JMPackingList.CustomerName;
                    tbPieces.Text = JMPackingList.PieceCount.ToString() + " pieces";
                    tbWeight.Text = JMPackingList.TotalWeight.ToString() + " kg";
                    tbUnits.Text = JMPackingList.ShippingUnitCount.ToString() + " shipping units";
                }
            }
        }

        private PLRecord GetPackingListData(string url)
        {
            PLRecord JMPackingList = new PLRecord();
            WebRequest apiRequest = WebRequest.Create(url);
            apiRequest.Proxy = null;
            HttpWebResponse apiResponse = (HttpWebResponse)apiRequest.GetResponse();

            if (apiResponse.StatusCode == HttpStatusCode.OK)
            {
                string xmlOutput;
                using (StreamReader sr = new StreamReader(apiResponse.GetResponseStream()))
                    xmlOutput = sr.ReadToEnd();
                if (xmlOutput == "\r\n")
                    return null;
                XmlSerializer xmlSerialize = new XmlSerializer(typeof(PLRecord));

                var xmlResult = (PLRecord)xmlSerialize.Deserialize(new StringReader(xmlOutput));

                if (xmlResult != null)
                    return (PLRecord)xmlResult;
                else
                    return null;
            }
            return null;
        }
        private PieceRecord GetPieceData(string url)
        {
            PieceRecord JMPiece = new PieceRecord();
            WebRequest apiRequest = WebRequest.Create(url);
            apiRequest.Proxy = null;
            HttpWebResponse apiResponse = (HttpWebResponse)apiRequest.GetResponse();

            if (apiResponse.StatusCode == HttpStatusCode.OK)
            {
                string xmlOutput;
                using (StreamReader sr = new StreamReader(apiResponse.GetResponseStream()))
                    xmlOutput = sr.ReadToEnd();
                if (xmlOutput == "\r\n")
                    return null;
                XmlSerializer xmlSerialize = new XmlSerializer(typeof(PieceRecord));

                var xmlResult = (PieceRecord)xmlSerialize.Deserialize(new StringReader(xmlOutput));

                if (xmlResult != null)
                    return (PieceRecord)xmlResult;
                else
                    return default(PieceRecord);
            }
            return null;
        }
    }
}
