using Designo.Website.Database;
using Designo.Website.Models;
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

    public List<Location> Locations { get; set; } = new List<Location>();



    public async Task OnGet()
    {
        Locations = await context.Locations.ToListAsync();
    }
}
