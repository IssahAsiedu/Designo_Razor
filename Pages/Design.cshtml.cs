using Designo.Website.Database;
using Designo.Website.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Designo.Website.Pages;
public class DesignModel : PageModel
{
    private readonly DesignoContext context;

    public DesignCategory? Category { get; set; }

    public List<DesignCategory> OtherCategories { get; set; } = new List<DesignCategory>();

    public List<Design> Designs { get; set; } = new List<Design>();


    public DesignModel(DesignoContext context)
    {
        this.context = context;
    }

    public async Task OnGet(string name)
    {
        Category = await context.DesignCategories.FirstAsync(c => c.Name!.ToLower() == name.ToLower());

        Designs = await context.Designs.Where(d => d.DesignCategoryId == Category.Id).ToListAsync();

        OtherCategories = await context.DesignCategories.Where(c => c.Name!.ToLower() != name.ToLower()).ToListAsync();
    }
}
