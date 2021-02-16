using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    [Serializable]
    public class ShippingUnitRecord
    {
        public int ShippingUnitNo { get; set; }
        public string ShippingUnitDescription { get; set; }
        public double TotalWeight { get; set; }
        public int PieceCount { get; set; }
        public List<PieceRecord> Pieces { get; set; }

    }
}
