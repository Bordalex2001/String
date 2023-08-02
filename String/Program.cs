using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main()
        {
            //8
            /*string str = "Language is a system";
            Console.WriteLine(str);
            Console.SetWindowSize(50, 30);
            str = str.Remove(12, 1);
            Console.WriteLine(str);*/

            //9
            /*string str = "Language is a system";
            Console.WriteLine(str);
            Console.SetWindowSize(50, 30);
            char symbol = 's';
            StringBuilder result = new StringBuilder(str.Length); 
            foreach (char ch in str)
            {
                if (ch != symbol)
                {
                    result.Append(ch);
                }
            }
            Console.WriteLine(result);*/

            //10
            /*string str = "Language is a system";
            Console.WriteLine(str);
            Console.SetWindowSize(50, 30);
            str = str.Insert(5, "i");
            Console.WriteLine(str);*/

            //11
            /*Console.Write("Enter string to check if it's palindrome: ");
            string str = Console.ReadLine();
            Console.SetWindowSize(50, 30);
            char[] symbols = str.ToCharArray();
            Array.Reverse(symbols);
            string reverse = new string(symbols);
            if (str.Equals(reverse))
            {
                Console.WriteLine("It's palindrome.");
            }
            else
            {
                Console.WriteLine("It's not palindrome.");
            }
            Console.WriteLine();*/

            //12
            /*Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.SetWindowSize(50, 30);
            int words = 1;
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] == ' ')
                {
                    words++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Number of words in string: " + words);*/

            //13
            /*Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Original text: " + text);
            Console.SetWindowSize(50, 30);
            Console.Write("\nEnter word to find: ");
            string wordToFind = Console.ReadLine();
            Console.Write("Enter word to replace: ");
            string wordToReplace = Console.ReadLine();
            StringBuilder result = new StringBuilder(text);
            int i = 0;
            while ((i = result.ToString().IndexOf(wordToFind, i)) != -1)
            {
                result.Replace(wordToFind, wordToReplace);
                i += wordToReplace.Length;
            }
            Console.WriteLine();
            Console.WriteLine("Text after word replacement: " + result);*/

            //14
            /*Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.SetWindowSize(50, 30);
            StringBuilder result = new StringBuilder(str.Length);
            string[] words = str.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length - 1; i += 2)
            {
                result.Append(words[i + 1]);
                result.Append(' ');
                result.Append(words[i]);
                result.Append(' ');
            }
            if (words.Length % 2 != 0)
            {
                result.AppendLine(words[words.Length - 1]);
            }
            else
            {
                result.Length--;
            }
            Console.WriteLine();
            Console.WriteLine("Result: " + result);*/

            //15
            /*Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.SetWindowSize(50, 30);
            string vowels = "AaEeIiOoUu";
            string[] words = str.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
            {
                if (vowels.IndexOf(word[word.Length - 1]) >= 0)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count + " words ends with vowel letter.");*/
        }
    }
}