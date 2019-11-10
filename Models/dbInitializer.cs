using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace landerReact.Models
{
    public class dbInitializer
    {
        public static void Initialize(TextPostContext context)
        {
            context.Database.EnsureCreated();

            if (!context.TextPost.Any())
            {
                var post = new TextPost()
                {
                    Content = "dit is een post",
                    DatePosted = DateTime.Now,
                    Likes = 2,
                    Title = "test title",
                    User = "Lander"
                };
                context.TextPost.Add(post);
                context.SaveChanges();
            }
        }
    }
}
