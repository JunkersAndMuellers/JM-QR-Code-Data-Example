using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    [Serializable]
    public class PLRecord
    {
        public int PackinglistNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerZipcode { get; set; }
        public string CustomerCity { get; set; }
        public int PieceCount { get; set; }
        public double TotalWeight { get; set; }
        public int ShippingUnitCount { get; set; }
        public List<ShippingUnitRecord> ShippingUnits { get; set; }
    }
}
