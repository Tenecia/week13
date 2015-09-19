using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChallengeOne
{
    class Program
    {
       // private const string InputFileName = "Problem1.html";
        //private const string Charset = "windows-1251";
         
        static void Main(string[] args)
        {
           
            StreamReader reader = new StreamReader("..\\..\\Tags.txt");

            StreamWriter writer = new StreamWriter("..\\..\\Notags.txt");
            StringBuilder builder = new StringBuilder();
            using (reader)
            {
                //int lineNumber = 0; // do not need just prints line number 
                string line = reader.ReadLine();// will read line for while loop 
                while (line!=null)
                {
                   // lineNumber++;   // do not need , just prints line number. 
                    int start = line.IndexOf("<");
                    int end = line.IndexOf(">");

                    while (start != -1) //will keep us moving through the loop if doesnt = -1
                    {
                        line = line.Remove(start, end-start+1);// remove first index
                                               
                        start = line.IndexOf("<"); // will print the left over words
                        end = line.IndexOf(">");// will print the left over words 
                                              
                    }
                    
                    line = line.Trim(); // will trim all the empty tag spaces 
                    if (line != "")// if line is not empty then append 
                    {
                        builder.AppendLine(line);// so it will append all the tag removals 
                    }
                                                            
                    //Console.WriteLine(line); // writes the line

                   
                    line = reader.ReadLine();// will read line again 

                   
                }
                // take out put and convert form stringbulider to a string 
                // builder convert to a string , then writeline builder to string          
                            

            }

            using (writer)
            {
                writer.Write(builder.ToString());
                Console.WriteLine(builder.ToString());
            }

        }


    }
}











    

