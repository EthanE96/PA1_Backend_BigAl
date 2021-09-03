using System;
using System.Collections.Generic;

namespace PA1_Backend_BigAl
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFile file = new DataFile(){fileName= "posts.txt"};
            List<Posts> bigAlPosts = file.ReadFile();

            System.Console.WriteLine("Big Al's Posts!");
            System.Console.WriteLine();
            Menu(bigAlPosts);
        }

        static void Menu(List<Posts> bigAlPosts){
            string userAns = ""; 
            while (userAns != "exit"){
                MenuDisplay();
                userAns = Console.ReadLine().ToLower();
                switch (userAns){
                    case "show all posts":
                        Console.Clear();
                        foreach (Posts post in bigAlPosts)
                        {
                            System.Console.WriteLine($"Post ID: {post.postID}, Post: {post.postText}, Timestamp: {post.timeDate}");
                        }
                        
                    break;
                    case "add a post":
                        Console.Clear();
                    

                    break;
                    case "delete a post":
                        Console.Clear();
                    


                    break;
                    case "exit":
                    userAns = "exit";
                    break;
                    default:
                    Console.Clear();
                    System.Console.WriteLine("Invaild response, try again");
                    break;
                }
            }
        }

        static void MenuDisplay(){
            System.Console.WriteLine("\u25A0   'Show all posts'");
            System.Console.WriteLine("\u25A0   'Add a post'");
            System.Console.WriteLine("\u25A0   'Delete a post'");
            System.Console.WriteLine("\u25A0   'Exit'");
        }

    
    }
}
