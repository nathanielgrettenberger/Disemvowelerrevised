using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            /// this program is going to be awesome
            disemvol(" this problem tested my brain");
            Console.ReadKey();
        }
        // create the fucntion here
        static void disemvol(string input)
        {
            string disemvowel = null;
            string vowel = null;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowel = vowel + letter;
                }
                else
                {
                    if (letter != ' ')
                    {
                        disemvowel = disemvowel + letter;

                    }
                }
            }
            Console.WriteLine(" disemvowel: " + disemvowel);
            Console.WriteLine(" vowel: " + vowel);
        }
        // take an input

        // create the two vars that will hold the output value
        //create a loop that starts at zero that goes untill the length of the input
        //make the letter equal to
        //
    }

}
    