using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Assignment_2___Online_Grocery_Membership_Prototype_Cardinal_.Pages;
using Assignment2;

public class ShopperHomeModel : PageModel
{
    private readonly ILogger<ShopperHomeModel> _logger;
    private readonly DBContext _context;

    public ShopperHomeModel(DBContext context,ILogger<ShopperHomeModel> logger)
    {
        _context=context;
        _logger = logger;
    }

    public void OnGet()
    {
    }
}