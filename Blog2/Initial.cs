using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog2.Models;

namespace Blog2
{
    public class Initial
    {
        public static void Ititialize(UserContext context)
        {
            if (!context.Posts.Any())
            {
                context.Posts.AddRange(
                    new Post
                    {
                        id = 1,
                        Label = "lonely",
                        content = "when I lay off",
                        UserID = default
                    },
                    new Post
                    {
                        id = 2,
                        Label = "further",
                        content = "brave new world is coming, ready or not",
                        UserID = default
                    },
                    new Post
                    {
                        id = 3,
                        Label = "black milk",
                        content = "we used to be happy before you flew away",
                        UserID = default
                    }
                    );
                context.SaveChangesAsync();
            }
        }
    }
}
