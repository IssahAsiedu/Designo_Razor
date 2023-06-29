using Designo.Website.Database;
using Designo.Website.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Designo.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly DesignoContext context;

        public List<DesignCategory> Categories { get; set; } = new List<DesignCategory>();

        public IndexModel(ILogger<IndexModel> logger, DesignoContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        public async Task OnGet()
        {
          Categories =  await context.DesignCategories.ToListAsync();
        }
    }
}