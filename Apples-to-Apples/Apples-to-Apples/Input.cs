using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2AInput
{
    public static class Input
    {
        public static int ReadInteger(string prompt, int min, int max, int x = 0)
        {
            Console.CursorLeft = x;
            int result = 0;
            bool isComplete = false;
            //Show the prompt
            Console.WriteLine(prompt);
            while (!isComplete)
            {
                
                //Read input
                string input = Console.ReadLine();
                
                //Check input
                if (!int.TryParse(input, out result))
                {
                    Console.CursorLeft = x;
                    Console.WriteLine("That is not an acceptable integer, please try again.");
                    continue;
                }
                else if (result < min || result > max)
                {
                    Console.CursorLeft = x;
                    Console.WriteLine("That is not an acceptable integer, please try again.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            //Return integer
            return result;
        }
        public static void ReadString(string prompt, ref string value, int x = 0)
        {
            Console.CursorLeft = x;
            bool isComplete = false;
            string input;
            //Show the prompt
            Console.WriteLine(prompt);
            while (!isComplete)
            {
               
                //Read input
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.CursorLeft = x;
                    Console.WriteLine("Not an acceptable string, please try again.");
                }
                else
                {
                    //Store in ref parameter
                    value = input;
                    isComplete = true;
                }
            }
        }
        public static void ReadChoice(string prompt, string[] options, out int selection, int x = 0, int y = 0)
        {
            //List options
            for(int i = 0; i < options.Length; i++)
            {
                Console.CursorLeft = x;
                if (i == 0)
                {
                    Console.CursorTop = y;
                }
                
                Console.WriteLine(i+1 + ": " + options[i] + "\n");
            }
            //Get the user's selection
            selection = ReadInteger(prompt, 1, options.Length, x);
        }
    }
}
