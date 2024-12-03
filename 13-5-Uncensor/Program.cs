// Solution to this: https://edabit.com/challenge/wunaXvZw3WctYioeC

namespace _13_5_Uncensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string uncensored = Uncensor("Th* c*k* *s * l**", "eaeiaie");
            Console.WriteLine(uncensored);  
        }

        static string Uncensor(string censoredWords, string vowels)
        {
            string returnValue = "";
            int charCount = 0;
            foreach (char c in censoredWords)
            {
                if (c == '*')
                {
                    returnValue += vowels[charCount];
                    charCount++;
                }
                else
                {
                    returnValue += c;
                }
            }

            return returnValue;
        }
    }
}
