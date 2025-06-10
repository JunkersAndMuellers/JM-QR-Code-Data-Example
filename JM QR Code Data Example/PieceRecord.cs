using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    /// <summary>
    /// Represents a detailed record of a manufactured piece/item containing all relevant
    /// production data, measurements, order information, and quality control data.
    /// </summary>
    [Serializable]
    public class PieceRecord
    {
        #region Basic Identification

        /// <summary>
        /// Unique piece number for identifying this specific piece.
        /// </summary>
        public int PieceNo { get; set; }

        /// <summary>
        /// Batch number this piece belongs to.
        /// </summary>
        public int BatchNo { get; set; }

        /// <summary>
        /// Internal article number/SKU for the manufactured item.
        /// </summary>
        public string ArticleNo { get; set; }

        /// <summary>
        /// Description of the article/item.
        /// </summary>
        public string ArticleDescription { get; set; }

        /// <summary>
        /// ID of the machine used to produce this piece (nullable).
        /// </summary>
        public int? MachineID { get; set; }

        #endregion

        #region Metric Measurements

        /// <summary>
        /// Gross/total length measurement in metric units.
        /// </summary>
        public decimal? Brut { get; set; }

        /// <summary>
        /// Allowance/waste measurement in metric units.
        /// </summary>
        public decimal? Allowance { get; set; }

        /// <summary>
        /// Net/usable length measurement in metric units.
        /// </summary>
        public decimal? Net { get; set; }

        /// <summary>
        /// Gross area measurement in square meters.
        /// </summary>
        public decimal? BrutM2 { get; set; }

        /// <summary>
        /// Allowance/waste area in square meters.
        /// </summary>
        public decimal? AllowanceM2 { get; set; }

        /// <summary>
        /// Net/usable area in square meters.
        /// </summary>
        public decimal? NetM2 { get; set; }

        #endregion

        #region Cell/Unit Measurements

        /// <summary>
        /// Gross measurement in cells/units.
        /// </summary>
        public decimal? BrutCell { get; set; }

        /// <summary>
        /// Allowance/waste in cells/units.
        /// </summary>
        public decimal? AllowanceCell { get; set; }

        /// <summary>
        /// Net/usable measurement in cells/units.
        /// </summary>
        public decimal? NetCell { get; set; }

        /// <summary>
        /// Total number of cells/units.
        /// </summary>
        public decimal? CellCount { get; set; }

        #endregion

        #region Weight Measurements

        /// <summary>
        /// Gross weight including packaging and containers.
        /// </summary>
        public decimal? WeightBrut { get; set; }

        /// <summary>
        /// Tare weight (weight of packaging/containers).
        /// </summary>
        public decimal? Tare { get; set; }

        /// <summary>
        /// Net weight (gross weight minus tare).
        /// </summary>
        public decimal? WeightNet { get; set; }

        /// <summary>
        /// Raw material weight.
        /// </summary>
        public decimal? WeightRM { get; set; }

        /// <summary>
        /// Weight per square meter.
        /// </summary>
        public decimal? WeightM2 { get; set; }

        #endregion

        #region Physical Properties

        /// <summary>
        /// Width measurement of the piece.
        /// </summary>
        public decimal? Width { get; set; }

        /// <summary>
        /// Quality grade or classification of the piece.
        /// </summary>
        public string Quality { get; set; }

        #endregion

        #region Imperial Measurements (Feet)

        /// <summary>
        /// Gross length measurement in feet.
        /// </summary>
        public decimal? BrutFeet { get; set; }

        /// <summary>
        /// Allowance/waste measurement in feet.
        /// </summary>
        public decimal? AllowanceFeet { get; set; }

        /// <summary>
        /// Net/usable length measurement in feet.
        /// </summary>
        public decimal? NetFeet { get; set; }

        /// <summary>
        /// Gross area measurement in square feet.
        /// </summary>
        public decimal? BrutSquareFeet { get; set; }

        /// <summary>
        /// Allowance/waste area in square feet.
        /// </summary>
        public decimal? AllowanceSquareFeet { get; set; }

        /// <summary>
        /// Net/usable area in square feet.
        /// </summary>
        public decimal? NetSquareFeet { get; set; }

        #endregion

        #region Imperial Measurements (Inches)

        /// <summary>
        /// Gross length measurement in inches.
        /// </summary>
        public decimal? BrutInch { get; set; }

        /// <summary>
        /// Allowance/waste measurement in inches.
        /// </summary>
        public decimal? AllowanceInch { get; set; }

        /// <summary>
        /// Net/usable length measurement in inches.
        /// </summary>
        public decimal? NetInch { get; set; }

        /// <summary>
        /// Gross area measurement in square inches.
        /// </summary>
        public decimal? BrutSquareInch { get; set; }

        /// <summary>
        /// Allowance/waste area in square inches.
        /// </summary>
        public decimal? AllowanceSquareInch { get; set; }

        /// <summary>
        /// Net/usable area in square inches.
        /// </summary>
        public decimal? NetSquareInch { get; set; }

        #endregion

        #region Order Information

        /// <summary>
        /// Number of parts/components in this piece.
        /// </summary>
        public int? Parts { get; set; }

        /// <summary>
        /// Unique identifier for this piece record.
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        /// Order number this piece is associated with.
        /// </summary>
        public int? OrderNo { get; set; }

        /// <summary>
        /// Position number within the order.
        /// </summary>
        public int? OrderPos { get; set; }

        /// <summary>
        /// Customer's purchase order number.
        /// </summary>
        public string PurchaseOrder { get; set; }

        #endregion

        #region Customer Information

        /// <summary>
        /// Customer's internal reference number.
        /// </summary>
        public string CustomerReferenz { get; set; }

        /// <summary>
        /// Customer's article number for this item.
        /// </summary>
        public string CustomerArticleNo { get; set; }

        /// <summary>
        /// Customer's description of the article.
        /// </summary>
        public string CustomerArticleDesc { get; set; }

        #endregion

        #region Delivery and Invoice Information

        /// <summary>
        /// Delivery note number this piece is included in.
        /// </summary>
        public int? DeliveryNoteNo { get; set; }

        /// <summary>
        /// Position number within the delivery note.
        /// </summary>
        public int? DeliveryNotePos { get; set; }

        /// <summary>
        /// Invoice number for billing purposes.
        /// </summary>
        public int? InvoiceNo { get; set; }

        /// <summary>
        /// Harmonized System (HS) code for customs and trade classification.
        /// </summary>
        public string HSCode { get; set; }

        #endregion

        #region Quality Control

        /// <summary>
        /// List of errors or defects found in this piece during quality inspection.
        /// Each error record contains detailed information about the defect.
        /// </summary>
        public List<PieceErrorRecord> Errors { get; set; }

        #endregion
    }
}