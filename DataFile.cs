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
        
            //close
            inFile.Close();
            ListSort();
            return bigAlPosts;
        }

        public void WriteFile(){
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
            bigAlPosts.Sort((x, y) => DateTime.Compare(x.timeDate, y.timeDate));
        }

    }
}