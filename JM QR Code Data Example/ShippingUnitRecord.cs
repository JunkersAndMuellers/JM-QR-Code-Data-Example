using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    /// <summary>
    /// Represents a shipping unit (package, pallet, container, etc.) within a packing list,
    /// containing detailed information about the unit's contents, weight, and individual pieces.
    /// </summary>
    [Serializable]
    public class ShippingUnitRecord
    {
        #region Identification

        /// <summary>
        /// Packing list number this shipping unit belongs to.
        /// Links this shipping unit to its parent packing list.
        /// </summary>
        public int PackinglistNo { get; set; }

        /// <summary>
        /// Unique shipping unit number within the packing list.
        /// Used to identify individual packages, pallets, or containers.
        /// </summary>
        public int ShippingUnitNo { get; set; }

        /// <summary>
        /// Description of the shipping unit type or contents
        /// (e.g., "Wooden Pallet", "Cardboard Box", "Steel Container").
        /// </summary>
        public string ShippingUnitDescription { get; set; }

        #endregion

        #region Unit Summary

        /// <summary>
        /// Total weight of this shipping unit including all contained pieces
        /// and packaging materials, in the respective weight unit.
        /// </summary>
        public double TotalWeight { get; set; }

        /// <summary>
        /// Total number of individual pieces contained in this shipping unit.
        /// </summary>
        public int PieceCount { get; set; }

        #endregion

        #region Contents

        /// <summary>
        /// List of all individual pieces contained within this shipping unit.
        /// Each piece record contains detailed production and measurement data.
        /// </summary>
        public List<PieceRecord> Pieces { get; set; }

        #endregion
    }
}