using System;
using System.Collections.Generic;

namespace PA1_Backend_BigAl
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFile file = new DataFile(){fileName= "posts.txt", bigAlPosts= new List<Posts>()};
            file.ReadFile();

            Console.Clear();
            System.Console.WriteLine("Big Al's Posts!");
            System.Console.WriteLine();
            Menu(file.bigAlPosts, file);
        }

        static void Menu(List<Posts> bigAlPosts, DataFile file){
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
                        System.Console.WriteLine();
                                            
                    break;
                    case "add a post":
                        Console.Clear();
                        string[] tempPost = new string[3];

                        System.Console.WriteLine("");
                        System.Console.WriteLine("Enter Post ID:");
                        tempPost[0] = Console.ReadLine();
                        
                    
                        System.Console.WriteLine("");
                        System.Console.WriteLine("Enter Post Text:");
                        tempPost[1] = Console.ReadLine();

                        System.Console.WriteLine("");
                        System.Console.WriteLine("Enter Date / Time stamp:");
                        System.Console.WriteLine("Format: '9/4/2020 2:30:00 PM' ");
                        tempPost[2] = Console.ReadLine();

                        bigAlPosts.Add(new Posts(){
                            postID = int.Parse(tempPost[0]),
                            postText = tempPost[1],
                            timeDate = DateTime.Parse(tempPost[2]) }); 
                        file.WriteFile();
                        Console.Clear();

                    break;
                    case "delete a post":
                        Console.Clear();
                        System.Console.WriteLine("");
                        System.Console.WriteLine("What post ID do you want to delete?");
                        foreach (Posts post in bigAlPosts)
                        {
                            System.Console.WriteLine($"Post ID: {post.postID}");
                        }
                        System.Console.WriteLine();

                        int tempID = int.Parse(Console.ReadLine());    
                        bigAlPosts.RemoveAll(r => r.postID == tempID);
                        file.WriteFile();

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
