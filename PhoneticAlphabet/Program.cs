using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PhoneticAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "NATO PHONETIC TTS";

            string resp = "";
            bool notRecognized = false;
            do
            {
                Console.CursorVisible = true;
                Console.Clear();

                string nr = (notRecognized ? "COMMAND NOT RECOGNIZED\n" : "");
                Console.Write("ENTER 'INSTANT' FOR INSTANT READOUT\n" +
                              "ENTER 'SEQUENCE' FOR SEQUENCE READOUT\n" +
                              "ENTER 'QUIT' TO QUIT\n" +
                              "{0}INPUT: ", nr);
                resp = Console.ReadLine().ToUpper();
                bool stay = true;
                switch (resp)
                {
                    case "INSTANT":
                        Console.Clear();
                        Console.CursorVisible = false;
                        Console.WriteLine("PRESS 'ESC' TO RETURN TO SELECTION MENU\nPRESS A LETTER TO READ IT OUT");
                        while (stay)
                        {
                            ConsoleKey ck = Console.ReadKey(true).Key;
                            if (ck == ConsoleKey.Escape) { stay = false; break; }
                            PlayLetter(ck);
                        }
                        break;
                    case "SEQUENCE":
                        while (stay)
                        {
                            Console.Clear();
                            Console.WriteLine("ENTER '~' TO RETURN TO SELECTION MENU");
                            Console.Write("ENTER ANY STRING TO BE READ: ");
                            char[] word = Console.ReadLine().ToCharArray();
                            if (word.Length == 1 && word[0] == '~') { stay = false; break; }
                            for (int i = 0; i < word.Length; i++)
                            {
                                PlayLetter(word[i]);
                            }
                        }
                        break;
                    default:
                        notRecognized = true;
                        break;
                }
            } while (resp != "QUIT");
        }

        static void PlayLetter(char letter)
        {
            var soundFile = Properties.Resources.ResourceManager.GetStream(letter.ToString());
            SoundPlayer sp = new SoundPlayer(soundFile);
            sp.PlaySync();
        }

        static void PlayLetter(ConsoleKey key)
        {
            var soundFile = Properties.Resources.ResourceManager.GetStream(key.ToString().ToLower());
            SoundPlayer sp = new SoundPlayer(soundFile);
            sp.Play();
        }
    }
}
