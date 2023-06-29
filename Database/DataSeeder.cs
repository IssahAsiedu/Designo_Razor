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

        context.SaveChangesAsync();
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
                Img = "image-web-design.jpg"
            },
            new DesignCategory
            {
                Id = 2,
                Name = "APP",
                Img = "image-app-design.jpg"
            },
            new DesignCategory
            {
                Id = 3,
                Name = "GRAPHIC",
                Img = "image-graphic-design.jpg"
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
                Description = "A multi-carrier shipping website for ecommerce businesses"
            },
            new Design
            {
                Id = 2,
                Name = "TRANSFER",
                DesignCategoryId = 1,
                Description = "Site for low-cost money transfers and sending money within seconds"
            },
            new Design
            {
                Id = 3,
                Name = "PHOTON",
                DesignCategoryId = 1,
                Description = "A state-of-the-art music player with high-resolution audio and DSP effects"
            },
            new Design
            {
                Id = 4,
                Name = "BUILDER",
                DesignCategoryId = 1,
                Description = "Connects users with local contractors based on their location"
            },
            new Design
            {
                Id = 5,
                Name = "BLOGR",
                DesignCategoryId = 1,
                Description = "Blogr is a platform for creating an online blog or publication"
            },
            new Design
            {
                Id = 6,
                Name = "CAMP",
                DesignCategoryId = 1,
                Description = "Get expert training in coding, data, design, and digital marketing"
            },
            new Design
            {
                Id = 7,
                Name = "AIRFILTER",
                DesignCategoryId = 2,
                Description = "Solving the problem of poor indoor air quality by filtering the air"
            },
            new Design
            {
                Id = 8,
                Name = "EYECAM",
                DesignCategoryId = 2,
                Description = "Product that lets you edit your favorite photos and videos at any time"
            },
            new Design
            {
                Id = 9,
                Name = "FACEIT",
                DesignCategoryId = 2,
                Description = "Get to meet your favorite internet superstar with the faceit app"
            },
            new Design
            {
                Id = 10,
                Name = "TODO",
                DesignCategoryId = 2,
                Description = "A todo app that features cloud sync with light and dark mode"
            },
            new Design
            {
                Id = 11,
                Name = "LOOPSTUDIOS",
                DesignCategoryId = 2,
                Description = "A VR experience app made for Loopstudios"
            },
            new Design
            {
                Id = 12,
                Name = "TIM BROWN",
                DesignCategoryId = 3,
                Description = "A book cover designed for Tim Brown’s new release, ‘Change’"
            },
            new Design
            {
                Id = 13,
                Name = "BOXED WATER",
                DesignCategoryId = 3,
                Description = "A simple packaging concept made for Boxed Water"
            },
            new Design
            {
                Id = 14,
                Name = "SCIENCE!",
                DesignCategoryId = 3,
                Description = "A poster made in collaboration with the Federal Art Project"
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
