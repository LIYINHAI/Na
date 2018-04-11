using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT_Models
{
  public  class Comments
    {
        public int Commets_ID{get;set;}
        public int  User_ID{ get; set; }
        public int  Pro_ID{ get; set; }
        public string Comments_Content { get; set; }
        public DateTime Comments_Time { get; set; }
    }
}
