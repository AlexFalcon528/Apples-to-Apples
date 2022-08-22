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
            string nounList = "EnglishNouns";
            string adjList = "EnglishAdjs";
            string[] languages = new string[] { "English", "Japanese","French","Custom" };
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
                        Game(nounList, adjList);

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2://Settings
                        int settingSelection;
                        int settingSelection2;
                        Console.Clear();
                        Console.CursorLeft = 45;
                        Console.CursorTop = 5;
                        Console.WriteLine("Settings");
                        Input.ReadChoice("Select a setting to change", new string[] {"Noun Dictionary Language", "Adjective Dictionary Language"}, out settingSelection, 45, 10);
                        Console.Clear();
                        Input.ReadChoice("Select a language.", languages, out settingSelection2, 45, 10);
                        Console.Clear();
                        if(settingSelection == 1)//Noun Dictionary Language
                        {
                            switch (settingSelection2)
                            {
                                case 1://English
                                    nounList = "English";
                                    break;
                                case 2://Japanese
                                    nounList = "Japanese";
                                    break;
                                case 3://French
                                    nounList = "French";
                                    break;
                                case 4://Custom
                                    Input.ReadString("Input the name of your custom dictionary",ref nounList,45,10);
                                    break;
                            }
                        }
                        else if (settingSelection == 2)//Adjective Dictionary Language
                        {
                            switch (settingSelection2)
                            {
                                case 1://English
                                    nounList = "English";
                                    break;
                                case 2://Japanese
                                    nounList = "Japanese";
                                    break;
                                case 3://French
                                    nounList = "French";
                                    break;
                                case 4://Custom
                                    Input.ReadString("Input the name of your custom dictionary", ref nounList, 45, 10);
                                    break;
                            }
                        }
                        Console.CursorLeft = 45;
                        Console.CursorTop = 10;
                        Console.WriteLine("Setting saved.");
                        Console.CursorLeft = 45;
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3://Exit Game
                        isExit=true;
                        break;
                }
            }
        }
        static void Game(string nouns, string adjectives)
        {
            
        }
    }









}

