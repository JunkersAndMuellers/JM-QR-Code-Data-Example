using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using JM.Tools;

namespace JMQRCodeDataExample
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

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

        private async void btnGO_Click(object sender, EventArgs e)
        {
            btnGO.Enabled = false; // Disable button to prevent multiple clicks
            cancellationTokenSource.Cancel(); // Cancel previous requests
            cancellationTokenSource = new CancellationTokenSource(); // Create new token
            try
            {
                ClearTextBoxes();
                var token = cancellationTokenSource.Token;

                if (tbURL.Text.Contains("GetPiece?uid="))
                {
                    // Single Piece Data
                    tbType.Text = "JM-Piece";
                    var jmPiece = await FetchAndDeserializeAsync<PieceRecord>(tbURL.Text, token);
                    if (jmPiece != null)
                    {
                        tbType.Text = $"JM-Piece {jmPiece.PieceNo}";
                        tbArticleNo.Text = jmPiece.ArticleNo ?? string.Empty;
                        tbArticleDesc.Text = jmPiece.ArticleDescription ?? string.Empty;
                        tbWeightPiece.Text = $"{jmPiece.WeightBrut}/{jmPiece.WeightNet} kg";
                        tbLength.Text = $"{jmPiece.Brut}/{jmPiece.Net} m";
                    }
                }
                else
                {
                    // Packing List Data
                    tbType.Text = "JM-Packing list";
                    var jmPackingList = await FetchAndDeserializeAsync<PLRecord>(tbURL.Text, token);
                    if (jmPackingList != null)
                    {
                        tbType.Text = $"JM-Packing list No.: {jmPackingList.PackinglistNo}";
                        tbName.Text = jmPackingList.CustomerName ?? string.Empty;
                        tbPieces.Text = $"{jmPackingList.PieceCount} pieces";
                        tbWeight.Text = $"{jmPackingList.TotalWeight} kg";
                        tbUnits.Text = $"{jmPackingList.ShippingUnitCount} shipping units";
                    }
                }
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Operation canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGO.Enabled = true; // Re-enable button
            }
        }

        private void ClearTextBoxes()
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
        }

        private async Task<T> FetchAndDeserializeAsync<T>(string url, CancellationToken token) where T : class
        {
            try
            {
                var response = await httpClient.GetAsync(url, token);
                if (response.IsSuccessStatusCode)
                {
                    var xmlOutput = await response.Content.ReadAsStringAsync();
                    if (string.IsNullOrWhiteSpace(xmlOutput))
                        return null;
                    var xmlSerialize = new XmlSerializer(typeof(T));
                    return xmlSerialize.Deserialize(new StringReader(xmlOutput)) as T;
                }
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Network error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving {typeof(T).Name} data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
