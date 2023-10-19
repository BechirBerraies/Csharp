using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CraftShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace CraftShop.Controllers;
public class OrdersController : Controller
{
    private readonly CraftShopContext _context;
    public OrdersController(CraftShopContext context)
    {
        _context = context; 
    }

    [HttpPost("orders/create")]
    public IActionResult CreateOrder(Order newOrder)
    {
    Craft? craft = _context.Crafts.Include(craft => craft.Owner).FirstOrDefault(craft => craft.CraftId == newOrder.CraftId);
        if(ModelState.IsValid)
        {
            if(craft.Quantity >= newOrder.Quantity)
            {

            _context.Add(entity: newOrder);
            craft.Quantity -= newOrder.Quantity;
            _context.SaveChanges();
            return RedirectToAction("ShopCraft","Crafts");
            }
            ModelState.AddModelError("Quantity", "Please Enter Quantity !");
            return View("~/Views/Crafts/ShowCraft.cshtml",craft);
        }
        return View("~/Views/Crafts/ShowCraft.cshtml",craft);
    }


    [HttpGet("orderhistory")]
    public IActionResult OrderHistory()
    
    {   
         if (HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("LogREg",controllerName:"Users");
        }
        int? UserId = (int)HttpContext.Session.GetInt32("userId");
        // User user = _context.Users
        // User? sales = _context.Users.Include(p => p.MyOrders).ThenInclude(p => p.Craft).ThenInclude(craft => craft.Owner).FirstOrDefault(user => user.UserId == UserId);
        // OrderViewHistory orderHistory = new OrderViewHistory();
        List<Order>? orders = _context.Orders.Include(craft => craft.Craft).ThenInclude(craft => craft.Owner).Where(order => order.UserId == UserId).ToList();
        List<Order>? sales = _context.Orders.Include(p => p.Buyer).Include(craft => craft.Craft).ThenInclude(craft => craft.Owner).Where(order => order.Craft.UserId == UserId).ToList();

        OrderViewHistory orderHistoryView = new OrderViewHistory(){
            
        }
        return View(orders);

    }


    


}