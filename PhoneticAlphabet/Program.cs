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
                        Thread.Sleep(1250);
                    }
                }
            }
        }

        static void PlayLetter(char letter)
        {
            switch (letter)
            {
                case 'a':
                    (new SoundPlayer("a.wav")).Play();
                    break;

                case 'b':
                    (new SoundPlayer("b.wav")).Play();

                    break;

                case 'c':
                    (new SoundPlayer("c.wav")).Play();

                    break;

                case 'd':
                    (new SoundPlayer("d.wav")).Play();

                    break;

                case 'e':
                    (new SoundPlayer("e.wav")).Play();

                    break;

                case 'f':
                    (new SoundPlayer("f.wav")).Play();

                    break;

                case 'g':
                    (new SoundPlayer("g.wav")).Play();

                    break;

                case 'h':
                    (new SoundPlayer("h.wav")).Play();

                    break;

                case 'i':
                    (new SoundPlayer("i.wav")).Play();

                    break;

                case 'j':
                    (new SoundPlayer("j.wav")).Play();

                    break;

                case 'k':
                    (new SoundPlayer("k.wav")).Play();

                    break;

                case 'l':
                    (new SoundPlayer("l.wav")).Play();

                    break;

                case 'm':
                    (new SoundPlayer("m.wav")).Play();

                    break;

                case 'n':
                    (new SoundPlayer("n.wav")).Play();

                    break;

                case 'o':
                    (new SoundPlayer("o.wav")).Play();

                    break;

                case 'p':
                    (new SoundPlayer("p.wav")).Play();

                    break;

                case 'q':
                    (new SoundPlayer("q.wav")).Play();

                    break;

                case 'r':
                    (new SoundPlayer("r.wav")).Play();

                    break;

                case 's':
                    (new SoundPlayer("s.wav")).Play();

                    break;

                case 't':
                    (new SoundPlayer("t.wav")).Play();

                    break;

                case 'u':
                    (new SoundPlayer("u.wav")).Play();

                    break;

                case 'v':
                    (new SoundPlayer("v.wav")).Play();

                    break;

                case 'w':
                    (new SoundPlayer("w.wav")).Play();

                    break;

                case 'x':
                    (new SoundPlayer("x.wav")).Play();

                    break;

                case 'y':
                    (new SoundPlayer("y.wav")).Play();

                    break;

                case 'z':
                    (new SoundPlayer("z.wav")).Play();
                    break;
            }
        }

        static void PlayLetter(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    (new SoundPlayer("a.wav")).Play();
                    break;

                case ConsoleKey.B:
                    (new SoundPlayer("b.wav")).Play();

                    break;

                case ConsoleKey.C:
                    (new SoundPlayer("c.wav")).Play();

                    break;

                case ConsoleKey.D:
                    (new SoundPlayer("d.wav")).Play();

                    break;

                case ConsoleKey.E:
                    (new SoundPlayer("e.wav")).Play();

                    break;

                case ConsoleKey.F:
                    (new SoundPlayer("f.wav")).Play();

                    break;

                case ConsoleKey.G:
                    (new SoundPlayer("g.wav")).Play();

                    break;

                case ConsoleKey.H:
                    (new SoundPlayer("h.wav")).Play();

                    break;

                case ConsoleKey.I:
                    (new SoundPlayer("i.wav")).Play();

                    break;

                case ConsoleKey.J:
                    (new SoundPlayer("j.wav")).Play();

                    break;

                case ConsoleKey.K:
                    (new SoundPlayer("k.wav")).Play();

                    break;

                case ConsoleKey.L:
                    (new SoundPlayer("l.wav")).Play();

                    break;

                case ConsoleKey.M:
                    (new SoundPlayer("m.wav")).Play();

                    break;

                case ConsoleKey.N:
                    (new SoundPlayer("n.wav")).Play();

                    break;

                case ConsoleKey.O:
                    (new SoundPlayer("o.wav")).Play();

                    break;

                case ConsoleKey.P:
                    (new SoundPlayer("p.wav")).Play();

                    break;

                case ConsoleKey.Q:
                    (new SoundPlayer("q.wav")).Play();

                    break;

                case ConsoleKey.R:
                    (new SoundPlayer("r.wav")).Play();

                    break;

                case ConsoleKey.S:
                    (new SoundPlayer("s.wav")).Play();

                    break;

                case ConsoleKey.T:
                    (new SoundPlayer("t.wav")).Play();

                    break;

                case ConsoleKey.U:
                    (new SoundPlayer("u.wav")).Play();

                    break;

                case ConsoleKey.V:
                    (new SoundPlayer("v.wav")).Play();

                    break;

                case ConsoleKey.W:
                    (new SoundPlayer("w.wav")).Play();

                    break;

                case ConsoleKey.X:
                    (new SoundPlayer("x.wav")).Play();

                    break;

                case ConsoleKey.Y:
                    (new SoundPlayer("y.wav")).Play();

                    break;

                case ConsoleKey.Z:
                    (new SoundPlayer("z.wav")).Play();
                    break;
            }
        }
    }
}
