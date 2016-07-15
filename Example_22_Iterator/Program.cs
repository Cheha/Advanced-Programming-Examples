using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_22_Iterator
{
    class Morze
    {
        private static Dictionary<char, int[]> morzeTable = GetMorze();

        public static void Beep(char[] charArray) {
            int[] beepArray;
            foreach (char symbol in charArray) {
                Thread.Sleep(500);
                beepArray = morzeTable[symbol];
                foreach (int num in beepArray) {
                    switch (num)
                    {
                        case 0:
                            Console.Beep(600, 500);
                            break;
                        case 1:
                            Console.Beep(600, 1000);
                            break;
                        default:
                            Thread.Sleep(2000);
                            break;
                    }
                }
                
            }
        }

        static Dictionary<char, int[]> GetMorze()
        {
            return new Dictionary<char, int[]> {
                 {'A', new int[]{0,1} },
                 {'B', new int[]{1,0,0,0} },
                 {'C', new int[]{1,0,1,0} },
                 {'D', new int[]{1,0,0} },
                 {'E', new int[]{0} },
                 {'F', new int[]{0,0,1,0} },
                 {'G', new int[]{1,1,0} },
                 {'H', new int[]{0,0,0,0,0} },
                 {'I', new int[]{0,0} },
                 {'J', new int[]{0,1,1,1} },
                 {'K', new int[]{1,0,1} },
                 {'L', new int[]{0,1,0,0} },
                 {'M', new int[]{1,1} },
                 {'N', new int[]{1,0} },
                 {'O', new int[]{1,1,1} },
                 {'P', new int[]{0,1,1,0} },
                 {'Q', new int[]{1,1,0,1} },
                 {'R', new int[]{0,1,0} },
                 {'S', new int[]{0,0,0} },
                 {'T', new int[]{1} },
                 {'U', new int[]{0,0,1} },
                 {'V', new int[]{0,0,0,1} },
                 {'W', new int[]{0,1,1} },
                 {'X', new int[]{1,0,0,1} },
                 {'Y', new int[]{1,0,1,1} },
                 {'Z', new int[]{1,1,0,0} },
                 {' ', new int[] {2}}
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            Morze.Beep(text.ToUpper().ToCharArray());
        } 
    }
}
