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






    


}