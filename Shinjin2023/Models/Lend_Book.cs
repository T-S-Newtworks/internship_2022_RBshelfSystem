using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinjin2023.Models
{
    class Lend_Book
    {
        public String Sequence_No { get; set; }

        public String User_ID{ get; set; }

        public String Book_ID { get; set; }

        public DateTime Lend_Date { get; set; }

        public DateTime Return_Date { get; set; }
    }
}
