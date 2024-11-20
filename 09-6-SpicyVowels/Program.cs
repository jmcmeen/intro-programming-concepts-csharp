using LabUtils;

namespace _09_6_SpicyVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] potentialNames = new string[100];

            for(int i = 0; i< potentialNames.Length; i++)
            {
                potentialNames[i] = Fortuita.NextName(10);
            }

            foreach(string potentialName in potentialNames)
            {
                Console.WriteLine(potentialName);
            }
        }
    }
}
