using System.Collections;
using System.Collections.Generic;

namespace Song_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> Songs = new Queue<string>(Console.ReadLine().Split(", "));

            while (Songs.Count>0)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();

                if (command[0]=="Play")
                {
                    Songs.Dequeue();
                }
                 if (command[0]=="Add")
                {
                    string song = String.Join(" ", command.Skip(1));
                    if (Songs.Contains(song))
                    {
                        Console.WriteLine(song + " is already contained!");
                        continue;
                    }
                    Songs.Enqueue(song);
                    
                }
                if (command[0]=="Show")
                {
                    Console.WriteLine(string.Join(", ",Songs));
                }
                if (Songs.Count==0)
                {
                    Console.WriteLine("No more songs!");
                }
            }

            


        }
    }
}