using System;
using System.Collections.Generic;
using System.Linq;

namespace Capstone_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word:");
            string word = Console.ReadLine().ToLower();
            int vowelPlace = word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
            Console.WriteLine(PigLatin(word, vowelPlace));
        }

                public static string PigLatin(string word, int vowelPlace)
                {
                    int i = 0;
                    if (vowelPlace == -1)
                    {
                        word = word + "way";
                    }
                    else
                    {
                        for (; i < vowelPlace; i++)
                        {
                            word = word + word[i];
                        }
                        word = word.Substring(i);
                        word = word + "ay";
                    }
                    return word;
                }
      }
    }