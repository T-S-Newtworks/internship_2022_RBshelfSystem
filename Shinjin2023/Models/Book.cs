using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shinjin2023.Models
{
    class Book
    {
        public string Book_ID { get; set; }

        public string Title { get; set; }

        public string User_Name { get; set; }

        public DateTime? Return_Date { get; set; }

        public string User_ID { get; set; }

        public string Status_Name { get; set; }

        public DateTime? Touroku_Date { get; set; }


        public string Status_Cd { get; set; }


        public string Delete_Flag { get; set; }
    }
}
