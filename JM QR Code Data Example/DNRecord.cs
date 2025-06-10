using System;
using System.Collections.Generic;

namespace JM.Tools
{
    /// <summary>
    /// Represents a delivery note record containing all relevant information
    /// about a delivery, including customer and delivery addresses, contact details,
    /// and information about delivered items.
    /// </summary>
    [Serializable]
    public class DNRecord
    {
        /// <summary>
        /// Unique delivery note number for identifying the delivery note.
        /// </summary>
        public int DeliveryNoteNo { get; set; }

        #region Customer Address

        /// <summary>
        /// Name of the customer.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Street and house number of the customer.
        /// </summary>
        public string CustomerStreet { get; set; }

        /// <summary>
        /// Country of the customer.
        /// </summary>
        public string CustomerCountry { get; set; }

        /// <summary>
        /// Postal code of the customer.
        /// </summary>
        public string CustomerZipcode { get; set; }

        /// <summary>
        /// City of the customer.
        /// </summary>
        public string CustomerCity { get; set; }

        #endregion

        #region Delivery Address

        /// <summary>
        /// Name of the delivery recipient (may differ from customer).
        /// </summary>
        public string DeliveryName { get; set; }

        /// <summary>
        /// Street and house number of the delivery address.
        /// </summary>
        public string DeliveryStreet { get; set; }

        /// <summary>
        /// Country of the delivery address.
        /// </summary>
        public string DeliveryCountry { get; set; }

        /// <summary>
        /// Postal code of the delivery address.
        /// </summary>
        public string DeliveryZipcode { get; set; }

        /// <summary>
        /// City of the delivery address.
        /// </summary>
        public string DeliveryCity { get; set; }

        #endregion

        #region Contact Information

        /// <summary>
        /// Name of the contact person for this delivery.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Phone number of the contact person.
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// Email address of the contact person.
        /// </summary>
        public string ContactMail { get; set; }

        #endregion

        #region Delivery Details

        /// <summary>
        /// Total number of delivered pieces/items.
        /// </summary>
        public int PieceCount { get; set; }

        /// <summary>
        /// Total weight of the delivery in the respective weight unit.
        /// </summary>
        public double TotalWeight { get; set; }

        /// <summary>
        /// List of all individual items/positions of the delivery.
        /// Each element contains detailed information about a delivered item.
        /// </summary>
        public List<PieceRecord> Pieces { get; set; }

        #endregion
    }
}
