using Designo.Website.Database;
using Designo.Website.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Designo.Website.Pages
{
    public class AboutModel : PageModel
    {

        public readonly DesignoContext context;

        public AboutModel(DesignoContext context)
        {
            this.context = context;
        }

        public List<Location> Locations { get; set; } = new List<Location>();

        public List<AboutContent> Contents { get; init; } = new() 
        {
             new AboutContent() {
                Id = 1,
                Title = "World-class talent",
                Img = "image-world-class-talent.jpg",
                Intro = "We are a crew of strategists, problem-solvers, and technologists. Every design is thoughtfully crafted from concept to launch, ensuring success in its given market. We are constantly updating our skills in a myriad of platforms.",
                Content = "Our team is multi-disciplinary and we are not merely interested in form — content and meaning are just as important. We give great importance to craftsmanship, service, and prompt delivery. Clients have always been impressed with our high-quality outcomes that encapsulates their brand’s story and mission."
            },
            new AboutContent() {
                Id = 2,
                Title = "The real deal",
                Img = "image-real-deal.jpg",
                Intro = "As strategic partners in our clients’ businesses, we are ready to take on any challenge as our own.\r\nSolving real problems require empathy and collaboration, and we strive to bring a fresh perspective to every opportunity. We make design and technology more accessible and give you tools to measure success.",
                Content = "We are visual storytellers in appealing and captivating ways. By combining business and marketing strategies, we inspire audiences to take action and drive real results."
            }
        };

        public async Task OnGet()
        {
            Locations = await context.Locations.ToListAsync();
        }
    }
}
