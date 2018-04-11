using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT_Models
{
   public  class ReplyComments
    {
        public int ReplyComments_ID { get; set; }
        public int Comments_ID { get; set; }
        public int User_ID { get; set; }
        public string ReplyComments_Content { get; set; }
        public DateTime ReplyComments_Time { get; set; }
    }
}
