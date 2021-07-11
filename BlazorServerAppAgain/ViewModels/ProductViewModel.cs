using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppAgain.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string  Name { get; set; }
        public string  Description { get; set; }
        public int Price { get; set; }
        public DateTime MfgDate { get; set; }
        public string  Category { get; set; }
    }
}
