using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekmek.UI.ViewModels
{
    public class ProductVM
    {
        
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int CategoryID { get; set; }

    }
}