using System;
using System.Collections.Generic;
using System.IO;

namespace PA1_Backend_BigAl
{
    public class DataFile
    {
        /*
        Create a DateTime from a String string dateString = "7/10/1974 7:10:24 AM";  
        DateTime dateFromString = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);  
        Console.WriteLine(dateFromString.ToString());  
        */
        
        public string fileName { get; set; }
        public List<Posts> bigAlPosts { get; set; }
        public List<Posts> ReadFile(){
            /* The file read should use a try catch and successfully work if
            nothing is returned or if the file does not exist. */

            //open
            StreamReader inFile = new StreamReader(fileName);
            
            //process
            string tempLine = inFile.ReadLine();
            
            while (tempLine != null){
                string[] data = tempLine.Split("#");
                bigAlPosts.Add(new Posts(){
                    postID = int.Parse(data[0]),
                    postText = data[1],
                    timeDate = DateTime.Parse(data[2])});
                tempLine = inFile.ReadLine();
            }
        
            /* Figure out how to sort by descending timestamp order */
                //first sort list then populate to file

            //close
            inFile.Close();
            return bigAlPosts;
        }

        public void WriteFile(){
            //open
            StreamWriter outFile = new StreamWriter (fileName);

            //process
            foreach (Posts post in bigAlPosts){
                outFile.WriteLine($"{post.postID}#{post.postText}#{post.timeDate}");
            }

            //close
            outFile.Close();
        }

        public void listSort(){

        }

    }
}