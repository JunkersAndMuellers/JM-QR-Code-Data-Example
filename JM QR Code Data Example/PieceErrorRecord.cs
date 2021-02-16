using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Tools
{
    [Serializable]
    public class PieceErrorRecord
    {
        public string ErrorType { get; set; }
        public double Position { get; set; }
        public double Length { get; set; }
        public int ErrorCode { get; set; }
    }
}
