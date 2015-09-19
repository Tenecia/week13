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
           
            StreamReader reader = new StreamReader("..\\..\\Tags.txt"); // creating new reader object

            StreamWriter writer = new StreamWriter("..\\..\\Notags.txt"); // creating new writer object
            StringBuilder builder = new StringBuilder(); // creating new builder object
            using (reader)
            {
                //int lineNumber = 0; // do not need just prints line number 
                string line = reader.ReadLine();// will read line for while loop 
                while (line!=null) // while line does not equal null (no content)
                {
                   // lineNumber++;   // do not need , just prints line number. 
                    int start = line.IndexOf("<");
                    int end = line.IndexOf(">");

                    while (start != -1) //will keep us moving through the loop if doesnt = -1
                    {
                        line = line.Remove(start, end-start+1);// will remove starting at "start" which represents a number, and will remove "end-start+1" number of characters. The +1 is bc index starts at 0 
                                               
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
                writer.Write(builder.ToString()); // writes to txt file "Notags.txt" the builder which has been turned into string.
                Console.WriteLine(builder.ToString()); // write our changes to console.
            }

        }


    }
}











    

