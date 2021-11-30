using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace InvestecStringAnalyser
{
    public class InvestecStringAnalyser
    {
        static void Main(string[] args)
        {
            DuplicateOperations duplicateOperations = new DuplicateOperations();
            DuplicateOperations vowelOperations = new VowelOperations();
            DuplicateOperations vowelOrNonOperations = new VowelOrNonOperations();

            // Display title.
            Console.WriteLine("Investec Text Analyser\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the text.";
            Console.WriteLine("Please Enter Text to be Analysed:\n");
            string text = Console.ReadLine();

            //UNCOMMENT FOR INPUT VALIDATION
            /*    while (text == "" || text.All(Char.IsLetter))
                {
                    Console.WriteLine("Invalid! Please Enter Valid Text to be Analysed:");
                    text = Console.ReadLine();
                } */

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - For a Duplicate Character Check");
            Console.WriteLine("\t2 - To Count the Number of Vowels");
            Console.WriteLine("\t3 - To check if there are more vowels or non vowels");
            Console.WriteLine("\tYou may also enter a combination of '1', '2' and '3' to perform multiple checks");
            Console.Write("Your option? ");

            string option = Console.ReadLine();

            //UNCOMMENT FOR INPUT VALIDATION
            //int cleanText = 0;
            /*  
                while (!int.TryParse(option, out  cleanText))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    option = Console.ReadLine();
                }
            
            if (option.Contains("1") || option.Contains("2") || option.Contains("3"))
            {*/
            if (option.Contains("1"))
                {
                    Console.WriteLine(duplicateOperations.TextOperation(text));

                }

                if (option.Contains("2"))
                {
                    Console.WriteLine(vowelOperations.TextOperation(text));

                }

                if (option.Contains("3"))
                {
                    Console.WriteLine(vowelOrNonOperations.TextOperation(text));

                }
            //}
        }

        public class DuplicateOperations
        {

            static readonly int characters = 256;

            /* Fills count array with
               frequency of characters */
            static void FillCharCounts(String str,
                                     int[] count)
            {
                for (int i = 0; i < str.Length; i++)
                    count[str[i]]++;
            }

            /* Print duplicates present in
            the passed string */
            public virtual string TextOperation(String text)
            {

                // Create an array of size 256 and
                // fill count of every character in it
                int[] count = new int[characters];
                FillCharCounts(text, count);
                string dups = "";
                for (int i = 0; i < characters; i++)
                //if character count is greater than 1 and not a space then add to string
                    if (count[i] > 1 && (char)i != ' ')
                        dups += (char)i;
                if (dups != "")
                    return "Found the following Duplicates: " + dups;
                else
                    return "No duplicate values were found";
            }

        }

        public class VowelOperations : DuplicateOperations
        {
            public override string TextOperation(String text)
            {
                text = text.ToLower();
                int count = 0;
                //Create counter to increment on each unique vowel present
                count += text.Contains("a") ? 1 : 0;
                count += text.Contains("e") ? 1 : 0;
                count += text.Contains("i") ? 1 : 0;
                count += text.Contains("o") ? 1 : 0;
                count += text.Contains("u") ? 1 : 0;

                if (count > 0)
                    return "The number of vowels is " + count;
                else
                    return "No vowels were found";
            }
        }

        public class VowelOrNonOperations : DuplicateOperations
        {
            public override string TextOperation(string text)
            {
                //change to lower and remove whitespace
               string str =  Regex.Replace(text, @"\s","").ToLower();

                int i, len, vowel, cons;

                vowel = 0;
                cons = 0;
                len = str.Length;
                //loop through all letters and check for vowels or non vowels
                for (i = 0; i < len; i++)
                {

                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                    {
                        vowel++;
                    }
                    else
                    {
                        cons++;
                    }
                }
                if (vowel > cons)
                    return "The text has more vowels than non vowels";
                else if (cons > vowel)
                    return "The text has more non vowels than vowels";
                else
                    return "The text has an equal amount of vowels and non vowels";

            }

        }
    }
}
