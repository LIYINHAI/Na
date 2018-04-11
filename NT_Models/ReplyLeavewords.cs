using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT_Models
{
   public class ReplyLeavewords
    {
        public int ReplyLeavewords_ID{get;set;}
        public int Leavewords_ID { get; set; }
        public int User_ID { get; set; }
        public string ReplyLeavewords_Comment { get; set; }
        public DateTime ReplyLeavewords_Time { get; set; }
    }
}
