using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    /// <summary>
    /// Represents an error record for a piece/item, containing information about 
    /// defects, quality issues, or other problems detected during inspection or processing.
    /// </summary>
    [Serializable]
    public class PieceErrorRecord
    {
        /// <summary>
        /// Type or category of the error (e.g., "Scratch", "Dent", "Missing Part").
        /// </summary>
        public string ErrorType { get; set; }

        /// <summary>
        /// Position where the error occurs, typically measured from a reference point
        /// in the respective unit of measurement (e.g., millimeters, inches).
        /// </summary>
        public double Position { get; set; }

        /// <summary>
        /// Length or size of the error area in the respective unit of measurement.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Numeric error code for categorization and automated processing.
        /// Used for mapping to error descriptions, severity levels, or corrective actions.
        /// </summary>
        public int ErrorCode { get; set; }
    }
}