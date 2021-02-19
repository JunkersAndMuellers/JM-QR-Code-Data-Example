using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    [Serializable]
    public class PieceRecord
    {
        public int PieceNo { get; set; }
        public int BatchNo { get; set; }
        public string ArticleNo { get; set; }
        public string ArticleDescription { get; set; }
        public int? MachineID { get; set; }
        public decimal? Brut { get; set; }
        public decimal? Allowance { get; set; }
        public decimal? Net { get; set; }
        public decimal? BrutM2 { get; set; }
        public decimal? AllowanceM2 { get; set; }
        public decimal? NetM2 { get; set; }
        public decimal? BrutCell { get; set; }
        public decimal? AllowanceCell { get; set; }
        public decimal? NetCell { get; set; }
        public decimal? CellCount { get; set; }
        public decimal? WeightBrut { get; set; }
        public decimal? Tare { get; set; }
        public decimal? WeightNet { get; set; }
        public decimal? Weight_g_rm { get; set; }
        public decimal? Witdh { get; set; }
        public string Quality { get; set; }
        public decimal? WeightM2 { get; set; }
        //public decimal? GewichtBerechnet { get; set; }
        public decimal? BrutFeet { get; set; }
        public decimal? AllowanceFeet { get; set; }
        public decimal? NetFeet { get; set; }
        public decimal? BrutSquareFeet { get; set; }
        public decimal? AllowanceSquareFeet { get; set; }
        public decimal? NetSquareFeet { get; set; }
        public decimal? BrutInch { get; set; }
        public decimal? AllowanceInch { get; set; }
        public decimal? NetInch { get; set; }
        public decimal? BrutSquareInch { get; set; }
        public decimal? AllowanceSquareInch { get; set; }
        public decimal? NetSquareInch { get; set; }
        public int? Parts { get; set; }
        public string UID { get; set; }
        public int? OrderNo { get; set; }
        public int? OrderPos { get; set; }
        public string PurchaseOrder { get; set; }
        public string CustomerReferenz { get; set; }
        public string CustomerArticleNo { get; set; }
        public string CustomerArticleDesc { get; set; }
        public int? DeliveryNoteNo { get; set; }
        public int? DeliveryNotePos { get; set; }
        //public int? CustomerNo { get; set; }
        public int? InvoiceNo { get; set; }
        public string HSCode { get; set; }
        public List<PieceErrorRecord> Errors { get; set; }
    }

}
