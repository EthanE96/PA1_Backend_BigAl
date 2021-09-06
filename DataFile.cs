using System;
using System.Collections.Generic;
using System.IO;

namespace PA1_Backend_BigAl
{
    public class DataFile
    {        
        public string fileName { get; set; }
        public List<Posts> bigAlPosts { get; set; }
        public List<Posts> ReadFile(){
            bigAlPosts = new List<Posts>();

            //open
            StreamReader inFile = null;
            
            //Try catch works if nothing is returned or if the file doesn't exist
            try {
                inFile = new StreamReader("posts.txt");
            }
            catch (FileNotFoundException e) {
                System.Console.WriteLine($"File not found, returning blank list {e}");
                return bigAlPosts;
            }
    
            //process
            string tempLine = inFile.ReadLine();
            
            //List of post object poulated with the data from file
            //Auto implemented properties
            while (tempLine != null){
                string[] data = tempLine.Split("#");
                bigAlPosts.Add(new Posts(){
                    postID = int.Parse(data[0]),
                    postText = data[1],
                    timeDate = DateTime.Parse(data[2])});
                tempLine = inFile.ReadLine();
            }
        
            //close
            inFile.Close();
            ListSort();
            return bigAlPosts;
        }

        public void WriteFile(){
            //When ever a change is made it updates the file and sorts

            ListSort();
            //open
            StreamWriter outFile = new StreamWriter (fileName);

            //process
            foreach (Posts post in bigAlPosts){
                outFile.WriteLine($"{post.postID}#{post.postText}#{post.timeDate}");
            }

            //close
            outFile.Close();
        }

        public void ListSort(){
            //Displays posts in descending timestamp order
            //List sort method used to sort the data
            bigAlPosts.Sort((x, y) => DateTime.Compare(x.timeDate, y.timeDate));
        }
    }
}