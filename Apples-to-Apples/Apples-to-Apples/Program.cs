using System;
using System.Text;
using System.IO;
using A2AInput;
using System.Linq;

namespace Apples
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int selection;
            bool isExit = false;
            string[] options = new string[] { "Play Game", "Settings", "Exit Game" };
            string nounList = "English";
            string adjList = "English";
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
                                    //Save(); Testing purposes
                                    Console.CursorLeft = 35;
                                    Console.CursorTop = 5;
                                    Console.WriteLine("Please note: the file needs to be a .txt with words separated on new lines.");
                                    Input.ReadString("Input the name of your custom dictionary",ref nounList,35,10);
                                    Console.Clear();
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
                                    Console.CursorLeft = 35;
                                    Console.CursorTop = 5;
                                    Console.WriteLine("Please note: the file needs to be a .txt with words separated on new lines.");
                                    Input.ReadString("Input the name of your custom dictionary", ref nounList, 35, 10);
                                    Console.Clear();
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
            bool isGameEnd = false;
            Random random = new Random();
            List<string> nounList = Load(nouns+"Nouns");
            List<string> adjList = Load(adjectives+"Adjectives");
            /*Console.WriteLine(nounList[13]);
            Console.WriteLine(adjList[75]);*/
            while (!isGameEnd)
            {
                Console.Clear();
                Console.CursorLeft = 45;
                Console.CursorTop = 10;
                Console.WriteLine("Press Enter to display a new Red Apple");
                Console.Clear();
                Console.CursorLeft = 50;
                Console.CursorTop = 10;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(nounList[random.Next(nounList.Count)]+"\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                for(int i = 1; i <= 5; i++)
                {
                    Console.CursorLeft = 20 * i;
                    Console.Write(adjList[random.Next(adjList.Count)]);
                }
                Console.ResetColor();
                Console.WriteLine("\n\n\n\n\nWrite which one you think fits best on paper and decide how many points get awarded.");
                if(Input.ReadInteger("Continue? 1=y, 2=n", 1, 2, 45)==2){
                    Console.Clear();
                    isGameEnd = true;
                }

            }
        }
        static List<string> Load(string filePath)
        {
            filePath += ".txt";
            List<string> result = new List<string>();
            string loadedText;
            string[] temp;
            char delimiter = '\n';
            if (File.Exists(filePath))
            {
                loadedText = File.ReadAllText(filePath);
                temp = loadedText.Split(delimiter);
                foreach (string s in temp)
                {
                    result.Add(s);
                }
            }
            else
            {
                Console.WriteLine("Loading Error");
                return null;
            }
            return result;
        }
        static void Save()
        {
            using(StreamWriter sw = new StreamWriter("English.txt"))
            {
                sw.Write("Oh\nyeah\nbaby\nthis\nis\ngaming");
            }
        }
    }









}

