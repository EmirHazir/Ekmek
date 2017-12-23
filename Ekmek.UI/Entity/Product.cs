using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekmek.UI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stcok { get; set; }
        public bool IsApproved { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}