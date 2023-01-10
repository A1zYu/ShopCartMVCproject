using Microsoft.AspNetCore.Mvc;
using ShopCart.Web.Models;
using ShopCart.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Web.infrastructure.Components
{
    public class SmallCartViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<CardItem> cart = HttpContext.Session.GetJson<List<CardItem>>("Cart");
            SmallCartViewModel smallCartVM;
            if (cart == null || cart.Count == 0)
            {
                smallCartVM = null;
            }
            else
            {
                smallCartVM = new()
                {
                    NumberOfItems=cart.Sum(x=>x.Quantity),
                    TotalAmount=cart.Sum(x=>x.Quantity*x.Price)
                };
            }
            return View(smallCartVM);
        }
    }
}
