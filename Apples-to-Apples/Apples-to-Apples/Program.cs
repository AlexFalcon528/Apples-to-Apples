using System;
using System.Text;
using System.IO;
using A2AInput;

namespace Apples
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            bool isExit = false;
            string[] options = new string[] { "Play Game", "Settings", "Exit Game" };
            Console.CursorVisible = false;
            Console.CursorLeft = 45;
            Console.CursorTop = 10;
            Console.WriteLine("Welcome to Apples to Apples");
            Console.CursorLeft = 45;
            Console.WriteLine("Programmed by Alex Falcon\n");
            Console.CursorLeft = 45;
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            while (!isExit)
            {
                Input.ReadChoice("Select an option!", options,out selection,45,10);
                switch (selection)
                {
                    case 1: //Play Game
                        Console.Clear();


                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2://Settings
                        Console.Clear();


                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3://Exit Game
                        isExit=true;
                        break;
                }
            }
        }
    }









}

