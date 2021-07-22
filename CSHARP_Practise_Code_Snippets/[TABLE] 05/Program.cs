using System;

namespace _TABLE__05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your text");
            string text = Console.ReadLine();
            string textAfterTrim = TrimSpaces(text);
            string textAfterReverse = ReverseText(text);

            Console.WriteLine("Your text: {0}", text);
            Console.WriteLine("Your text after trim spaces: {0}", textAfterTrim);
            Console.WriteLine("Your text after reverse: {0}", textAfterReverse);
            Console.ReadKey();

        }

        static string TrimSpaces(string text)
        {
            //Target string, to hold a shortened version of the text
            string textWithoutSpaces = "";

            for(int i =0; i<text.Length; ++i)
            {
                // If the character is not empty, add it to the target string
                if(text[i]!= ' ' && text[i] != '\t' && text[i] != 'n')
                    textWithoutSpaces += text[i];
            }

            return textWithoutSpaces;
        }

        static string ReverseText(string text)
        {
            // Target string, to hold a reversed text
            string reversedTest = "";

            //This time we are going through the text from the back, starting from the last character
            for(int i = text.Length - 1; i >=0; --i)
            {
                // Add to the new string the character located
                // at the i-th position from the end in the original string
                reversedTest += text[i];
            }

            return reversedTest;
        }

    }
}
