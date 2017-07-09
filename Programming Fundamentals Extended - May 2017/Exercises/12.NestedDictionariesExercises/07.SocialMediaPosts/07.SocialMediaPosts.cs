using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Post
{
    public string PostName { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public Dictionary<string,string> Comments { get; set; }
}
class Program
{
    static void Main()
    {
        Dictionary<string,Dictionary<List<string>,List<int>>> dictionary = new Dictionary<string, Dictionary<List<string>, List<int>>>();
        List<Post> posts = new List<Post>();

        string command = Console.ReadLine();

        while (command != "drop the media")
        {
            List<string> split = command.Split().ToList();
            string action = split[0];
            string post = split[1];

            if (action == "post")
            {

                Post currentPost = new Post()
                {
                    PostName = post,
                    Likes = 0,
                    Dislikes = 0,
                    Comments = new Dictionary<string, string>()
                };

                posts.Add(currentPost);
            }
            else if (action == "like")
            {
                posts
                    .Where(p => p.PostName == post)
                    .ToList()[0]
                    .Likes++;
            }
            else if (action == "dislike")
            {
                posts
                    .Where(p => p.PostName == post)
                    .ToList()[0]
                    .Dislikes++;
            }
            else if (action == "comment")
            {
                string postName = string.Join("", command.Split().Skip(1).Take(1));
                string username = string.Join("", command.Split().Skip(2).Take(1));
                List<string> comment = command
                    .Split()
                    .Skip(3)
                    .ToList();

                posts
                    .Where(p => p.PostName == post)
                    .ToList()[0]
                    .Comments
                    .Add(username,command.Substring(7+postName.Length+username.Length+2));
            }
            //string.Join("",command.Split().Skip(2).Take(1)), string.Join("", command.Split().Skip(3))

            command = Console.ReadLine();
        }

        foreach (var post in posts)
        {
            Console.WriteLine($"Post: {post.PostName} | Likes: {post.Likes} | Dislikes: {post.Dislikes}");
            Console.WriteLine($"Comments:");
            if (post.Comments.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var comment in post.Comments)
                {
                    Console.WriteLine($"*  {comment.Key}:{comment.Value}");
                }
            }
        }
    }
}

