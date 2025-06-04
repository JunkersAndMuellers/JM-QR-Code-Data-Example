using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    /// <summary>
    /// Represents a packing list record containing customer information, 
    /// shipment totals, and detailed information about shipping units.
    /// Used for organizing and tracking shipments to customers.
    /// </summary>
    [Serializable]
    public class PLRecord
    {
        #region Identification

        /// <summary>
        /// Unique packing list number for identifying this shipment.
        /// </summary>
        public int PackinglistNo { get; set; }

        #endregion

        #region Customer Address

        /// <summary>
        /// Name of the customer receiving the shipment.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Street and house number of the customer's address.
        /// </summary>
        public string CustomerStreet { get; set; }

        /// <summary>
        /// Country of the customer's address.
        /// </summary>
        public string CustomerCountry { get; set; }

        /// <summary>
        /// Postal code of the customer's address.
        /// </summary>
        public string CustomerZipcode { get; set; }

        /// <summary>
        /// City of the customer's address.
        /// </summary>
        public string CustomerCity { get; set; }

        #endregion

        #region Shipment Totals

        /// <summary>
        /// Total number of individual pieces included in this shipment.
        /// </summary>
        public int PieceCount { get; set; }

        /// <summary>
        /// Total weight of the entire shipment in the respective weight unit.
        /// </summary>
        public double TotalWeight { get; set; }

        /// <summary>
        /// Total number of shipping units (packages, pallets, containers, etc.) 
        /// in this shipment.
        /// </summary>
        public int ShippingUnitCount { get; set; }

        #endregion

        #region Shipping Details

        /// <summary>
        /// List of all shipping units included in this packing list.
        /// Each shipping unit contains detailed information about its contents,
        /// dimensions, weight, and other relevant shipping data.
        /// </summary>
        public List<ShippingUnitRecord> ShippingUnits { get; set; }

        #endregion
    }
}