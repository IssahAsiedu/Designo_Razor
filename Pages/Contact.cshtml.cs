using Designo.Website.Database;
using Designo.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Designo.Website.Pages;
public class ContactsModel : PageModel
{
    public readonly DesignoContext context;

    public ContactsModel(DesignoContext context)
    {
        this.context = context;
    }


    [BindProperty]
    public Customer Customer { get; set; } = default!;

    public List<Location> Locations { get; set; } = new List<Location>();


    public async Task OnGet()
    {
        Locations = await context.Locations.ToListAsync();
    }

    public async Task OnPost()
    {
        Locations = await context.Locations.ToListAsync();

        if(ModelState.IsValid)
        {

            return;
        }

        if(ModelState.ContainsKey("Customer.Email"))
        {
           if (ModelState["Customer.Email"]!.ValidationState == ModelValidationState.Invalid)
            {
                ViewData["email_invalid"] = true;
            }
        }

    }
}
