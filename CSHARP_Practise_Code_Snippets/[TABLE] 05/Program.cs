using System;

namespace _TABLE__05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your text");
            string textBefore = Console.ReadLine();
            string textAfter = TrimSpaces(textBefore);

            Console.WriteLine("Your text before: {0}", textBefore);
            Console.WriteLine("Your text after: {0}", textAfter);
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
    }
}
