using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_rozszerzające
{
    static class MetodyRozszczerzajaceClass
    {
        public static string testMethod(this string napis)
        {
            string nowyNapis= "";
            
            for (int i = 0; i < napis.Length; i++)
            {
                string znak = napis[i].ToString();
                if (i % 2 == 0)
                {
                    znak = znak.ToString().ToUpper();
                }
                else
                {
                    znak = znak.ToString().ToLower();
                }
                nowyNapis += znak;
            }
            return nowyNapis;
        }
        public static string CreateTitle(this string napis)
        {
            string nowyNapis = "";

            nowyNapis += napis[0].ToString().ToUpper();

            for (int i = 1; i < napis.Length; i++)
            {
                if (napis[i - 1] == ' ')
                {
                    nowyNapis += napis[i].ToString().ToUpper();
                }
                else
                {
                    nowyNapis += napis[i];
                }
            }
            return nowyNapis;
        }

        public static string usunSamogloski(this string napis)
        {
            string nowyNapis = "";

            char[] znaki = { 'a', 'e', 'o', 'u', 'y', 'i', 'A', 'E', 'O', 'U', 'Y', 'I' };

            for (int i = 0; i < napis.Length; i++)
            {
                if (!znaki.Contains(napis[i]))
                {
                    nowyNapis += napis[i];
                }
                
            }
            return nowyNapis;
        }

        public static int worldCounter(this string napis)
        {
            int counter;

            string[] words = napis.Split(new char[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            counter = words.Length;
            return counter;
        }

        public static int[] worldLetterCounter(this string napis)
        {
           
            string[] words = napis.Split(new char[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            int[] counter = new int[words.Length];
            for (int i= 0; i < words.Length; i++)
            {
                counter[i] = words[i].Length;
            }
            return counter;
        }

        public static bool isZdaniem(this string napis)
        {
            char[] znak = {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D',
                        'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'X', 'C', 'V', 'B', 'N'};
            if (znak.Contains(napis[0]) && napis[napis.Length-1] == '.')
            {
                return true;
            }
            return false;
        }

        public static char najczesciejUzywana(this string napis)
        {
            char[] znak = {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D',
                        'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'X', 'C', 'V', 'B', 'N'};
            int[] powtorzen = new int[znak.Length];
            napis = napis.ToUpper();
            foreach (char item in napis)
            {
                for (int i = 0; i < znak.Length; i++)
                {
                    if (item == znak[i])
                    {
                        powtorzen[i]++;
                    }
                }
            }
            int max=powtorzen[0], maxIndex=0;
            
            for (int i = 1; i < znak.Length; i++)
            {
                if (powtorzen[i]>max)
                {
                    max = powtorzen[i];
                    maxIndex = i;
                }
            }
            return znak[maxIndex];
        }
    }
}
