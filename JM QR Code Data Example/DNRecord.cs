using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    [Serializable]
    public class DNRecord
    {
        public int DeliveryNoteNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerZipcode { get; set; }
        public string CustomerCity { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryStreet { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryZipcode { get; set; }
        public string DeliveryCity { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMail { get; set; }
        public int PieceCount { get; set; }
        public double TotalWeight { get; set; }
        public List<PieceRecord> Pieces { get; set; }
    }
}
