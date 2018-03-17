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
            Console.Write("Press 1 for instant, anything for word: ");
            int resp = 0;
            int.TryParse(Console.ReadLine(), out resp);

            if (resp == 1)
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Enter a letter: ");
                    PlayLetter(Console.ReadKey().Key);
                }
            }
            else
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Enter a word: ");
                    char[] word = Console.ReadLine().ToCharArray();
                    for(int i = 0; i <word.Length; i++)
                    {
                        PlayLetter(word[i]);
                    }
                }
            }
        }

        static void PlayLetter(char letter)
        {
            string location = letter.ToString();
            location = location.ToLower();
            location += ".wav";
            SoundPlayer sp = new SoundPlayer(location);
            sp.PlaySync();            
        }

        static void PlayLetter(ConsoleKey key)
        {
            string location = key.ToString();
            location = location.ToLower();
            location += ".wav";
            SoundPlayer sp = new SoundPlayer(location);
            sp.Play();
        }
    }
}
