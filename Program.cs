using System;

namespace PA1_Backend_BigAl
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Big Al's Posts!");
            System.Console.WriteLine();
            Menu();
        }

        static void Menu(){
            string userAns = ""; 
            while (userAns != "exit"){
                MenuDisplay();
                userAns = Console.ReadLine().ToLower();
                switch (userAns){
                    case "show all posts":
                    Posts();
                    break;
                    case "add a post":
                    Add();
                    break;
                    case "delete a post":
                    Delete();
                    break;
                    case "exit":
                    userAns = "exit";
                    break;
                    default:
                    System.Console.WriteLine("Invaild response, try again");
                    break;
                }
                Console.Clear();
            }
        }

        static void MenuDisplay(){
            System.Console.WriteLine("\u25A0   'Show all posts'");
            System.Console.WriteLine("\u25A0   'Add a post'");
            System.Console.WriteLine("\u25A0   'Delete a post'");
            System.Console.WriteLine("\u25A0   'Exit'");
        }

        static void Posts(){

        }
        static void Add(){

        }
        static void Delete(){

        }
    }
}
