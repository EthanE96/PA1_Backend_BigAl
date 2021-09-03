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
        public List<Posts> bigAlPosts {get; set; }
        public List<Posts> ReadFile(){
            
            /*
            The file read should use a try catch and successfully work if
            nothing is returned or if the file does not exist.
            */

            List<Posts> bigAlPosts = new List<Posts>();
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
            }
        
            /* Figure out how t`o sort by descending timestamp order */

            //close
            inFile.Close();
            return bigAlPosts;
        }

        public void WriteFile(){

        }

    }
}