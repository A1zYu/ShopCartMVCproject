using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Web.Models.ViewModels
{
    public class SmallCartViewModel
    {
        public int NumberOfItems { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
