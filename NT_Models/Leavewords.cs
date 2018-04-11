using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT_Models
{
   public class Leavewords
    {
        public int Leavewords_ID { get; set; }
        public int User_ID { get; set; }
        public int News_ID { get; set; }
        public string Leavewords_Content { get; set; }
        public DateTime Leavewords_Time{ get; set; }
    }
}
