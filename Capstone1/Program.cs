using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Capstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's convert a word into Pig Latin!");
            Console.WriteLine("*OR* as they say in Pig Latin-");
            Console.WriteLine("Et'slay onvertcay away ordway intoway Igpay Atinlay!");
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            string sentence = Console.ReadLine();
            string pigLatin = ToPigLatin(sentence);
            Console.WriteLine(pigLatin);

        }
        public static string ToPigLatin(string sentence)
        {
            string firstLetter,
                   //secondLetter,
                   restOfWord,
                   vowels = "aeiou";
       
            int currentLetter;


            foreach (string word in sentence.Split())
            {
                firstLetter = sentence.Substring(0, 1);
                //secondLetter = sentence.Substring(1, 2);
                restOfWord = sentence.Substring(1, sentence.Length - 1);
                firstLetter = word.Substring(0, ToPigLatin(word));
                //string beginning = word.Substring(0, IndexOfVowel(word));


                //restOfWord = sentence.Substring(2, sentence.Length - 2);
                currentLetter = vowels.IndexOf(firstLetter);
               // currentLetter = cons.IndexOf(restOfWord);

                if (currentLetter == -1) //|| currentLetter == -2 || currentLetter == -3)
                {
                    sentence = restOfWord + firstLetter + "ay:";
                }
                else
                {
                    sentence = word + "way";

                }

            }
            return sentence;

        }


    }
}



