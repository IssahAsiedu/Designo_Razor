using Designo.Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Designo.Website.Database;
public class DataSeeder
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new DesignoContext(serviceProvider.GetRequiredService<DbContextOptions<DesignoContext>>());

        if (context == null)
        {
            throw new ArgumentNullException($"Null: {nameof(context)}");
        }
        PopulateCoreValues(context);
        PopulateDesignCategories(context);
        PopulateDesigns(context);
        PopulateLocations(context);
        context.SaveChangesAsync();
    }

    private static void PopulateLocations(DesignoContext context)
    {
        context.Locations.AddRange(
            new Location()
            {
                Id = 1,
                Name = "Canada",
                Branch = "Central",
                Street = "3886 Wellington Street",
                City = "Toronto, Ontario M9C 3J5",
                PhoneNumber = "+1 253-863-8967",
                Email = "contact@designo.co",
                Img = "illustration-canada.svg",
                Map = "image-map-canada.png"
            },
            new Location()
            {
                Id = 2,
                Name = "Australia",
                Branch = "AU",
                Street = "19 Balonne Street",
                City = "New South Wales 2443",
                PhoneNumber = "(02) 6720 9092",
                Email = "contact@designo.au",
                Img = "illustration-australia.svg",
                Map = "image-map-australia.png"
            },
            new Location()
            {
                Id = 3,
                Name = "United Kingdom",
                Branch = "UK",
                Street = "13  Colorado Way",
                City = "Rhyd-y-fro SA8 9GA",
                PhoneNumber = "078 3115 1400",
                Email = "contact@designo.uk",
                Img = "illustration-united-kingdom.svg",
                Map = "image-map-uk.png"
            }
        );
    }

    public static void PopulateDesignCategories(DesignoContext context)
    {
        if (context.DesignCategories == null)
        {
            throw new ArgumentNullException($"Null: {nameof(DesignCategory)}");
        }

        if (context.DesignCategories.Any())
        {
            return;
        }

        context.DesignCategories.AddRange(
            new DesignCategory
            {
                Id = 1,
                Name = "WEB",
                Img = "image-web-design.jpg",
                SvgBackground = "web-design/desktop/bg-pattern-intro-web.svg",
                Description = "We build websites that serve as powerful marketing tools and bring memorable brand experiences."
            },
            new DesignCategory
            {
                Id = 2,
                Name = "APP",
                Img = "image-app-design.jpg",
                SvgBackground = "app-design/desktop/bg-pattern-intro-app.svg",
                Description = "Our mobile designs bring intuitive digital solutions to your customers right at their fingertips."
            },
            new DesignCategory
            {
                Id = 3,
                Name = "GRAPHIC",
                Img = "image-graphic-design.jpg",
                SvgBackground = "graphic-design/desktop/bg-pattern-intro-graphic.svg",
                Description = "We deliver eye-catching branding materials that are tailored to meet your business objectives."
            }
            );
    }

    public static void PopulateDesigns(DesignoContext context)
    {
        if (context.Designs == null)
        {
            throw new ArgumentNullException($"Null: {nameof(Design)}");
        }

        if (context.Designs.Any())
        {
            return;
        }

        context.Designs.AddRange
        (
            new Design
            {
                Id = 1,
                Name = "EXPRESS",
                DesignCategoryId = 1,
                Description = "A multi-carrier shipping website for ecommerce businesses",
                Img = "web-design/desktop/image-express.jpg"
            },
            new Design
            {
                Id = 2,
                Name = "TRANSFER",
                DesignCategoryId = 1,
                Description = "Site for low-cost money transfers and sending money within seconds",
                Img = "web-design/desktop/image-transfer.jpg"
            },
            new Design
            {
                Id = 3,
                Name = "PHOTON",
                DesignCategoryId = 1,
                Description = "A state-of-the-art music player with high-resolution audio and DSP effects",
                Img = "web-design/desktop/image-photon.jpg"
            },
            new Design
            {
                Id = 4,
                Name = "BUILDER",
                DesignCategoryId = 1,
                Description = "Connects users with local contractors based on their location",
                Img = "web-design/desktop/image-builder.jpg"
            },
            new Design
            {
                Id = 5,
                Name = "BLOGR",
                DesignCategoryId = 1,
                Description = "Blogr is a platform for creating an online blog or publication",
                Img = "web-design/desktop/image-blogr.jpg"
            },
            new Design
            {
                Id = 6,
                Name = "CAMP",
                DesignCategoryId = 1,
                Description = "Get expert training in coding, data, design, and digital marketing",
                Img = "web-design/desktop/image-camp.jpg"
            },
            new Design
            {
                Id = 7,
                Name = "AIRFILTER",
                DesignCategoryId = 2,
                Description = "Solving the problem of poor indoor air quality by filtering the air",
                Img = "app-design/desktop/image-airfilter.jpg"
            },
            new Design
            {
                Id = 8,
                Name = "EYECAM",
                DesignCategoryId = 2,
                Description = "Product that lets you edit your favorite photos and videos at any time",
                Img = "app-design/desktop/image-eyecam.jpg"
            },
            new Design
            {
                Id = 9,
                Name = "FACEIT",
                DesignCategoryId = 2,
                Description = "Get to meet your favorite internet superstar with the faceit app",
                Img = "app-design/desktop/image-faceit.jpg"
            },
            new Design
            {
                Id = 10,
                Name = "TODO",
                DesignCategoryId = 2,
                Description = "A todo app that features cloud sync with light and dark mode",
                Img = "app-design/desktop/image-todo.jpg"
            },
            new Design
            {
                Id = 11,
                Name = "LOOPSTUDIOS",
                DesignCategoryId = 2,
                Description = "A VR experience app made for Loopstudios",
                Img = "app-design/desktop/image-loopstudios.jpg"
            },
            new Design
            {
                Id = 12,
                Name = "TIM BROWN",
                DesignCategoryId = 3,
                Description = "A book cover designed for Tim Brown’s new release, ‘Change’",
                Img = "graphic-design/desktop/image-change.jpg"
            },
            new Design
            {
                Id = 13,
                Name = "BOXED WATER",
                DesignCategoryId = 3,
                Description = "A simple packaging concept made for Boxed Water",
                Img = "graphic-design/desktop/image-boxed-water.jpg"
            },
            new Design
            {
                Id = 14,
                Name = "SCIENCE!",
                DesignCategoryId = 3,
                Description = "A poster made in collaboration with the Federal Art Project",
                Img = "graphic-design/desktop/image-science.jpg"
            }
        );
    }

    public static void PopulateCoreValues(DesignoContext context)
    {
        if (context.CoreValues == null)
        {
            throw new ArgumentNullException($"Null {nameof(CoreValue)}");
        }

        if (context.CoreValues.Any())
        {
            return;
        }

        context.CoreValues.AddRange(
            new CoreValue
            {
                Id = 1,
                Title = "PASSIONATE",
                Description = "Each project starts with an in-depth brand research to ensure we only create products that serve a purpose. We merge art, design, and technology into exciting new solutions."
                ,
                Img = "illustration-passionate.svg"
            },
            new CoreValue
            {
                Id = 2,
                Title = "RESOURCEFUL",
                Description = "Everything that we do has a strategic purpose. We use an agile approach in all of our projects and value customer collaboration. It guarantees superior results that fulfill our clients’ needs."
            ,
                Img = "illustration-resourceful.svg"
            },
            new CoreValue
            {
                Id = 3,
                Title = "FRIENDLY",
                Description = " We are a group of enthusiastic folks who know how to put people first. Our success depends on our customers, and we strive to give them the best experience a company can provide."
            ,
                Img = "illustration-friendly.svg"
            }
        );
    }

}
