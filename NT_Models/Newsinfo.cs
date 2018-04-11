using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT_Models
{
   public class Newsinfo
    {
        public int News_ID { get; set;}
        public int Cull_ID { get; set; }
        public string News_Title { get; set; }
        public DateTime News_Time { get; set; }
        public string News_Contet { get; set; }
        public string News_Url { get; set; }
        public string News_Img { get; set; }
    }
}
