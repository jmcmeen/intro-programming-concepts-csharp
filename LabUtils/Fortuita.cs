namespace LabUtils
{
    /// <summary>
    /// Static wrapper class to get random values without working with Random directly
    /// </summary>
    public static class Fortuita
    {
        /// <summary>
        /// Returns a random int that is >=0 and < upperBound
        /// </summary>
        /// <param name="upperBound">upper boundary</param>
        /// <returns></returns>
        public static int GetRandomInt(int upperBound)
        {
            Random random = new Random();
            return random.Next(upperBound);
        }

        /// <summary>
        /// Returns a random int that is >=lowerBound and < upperBound
        /// </summary>
        /// <param name="lowerBound">lower bound (inclusive)</param>
        /// <param name="upperBound">upper bound (exclusive)</param>
        /// <returns></returns>
        public static int GetRandomInt(int lowerBound, int upperBound)
        {
            Random random = new Random();
            return random.Next(lowerBound, upperBound);
        }

        /// <summary>
        /// Generates a random proper name.. probably not a lot that you've heard before
        /// </summary>
        /// <param name="maxLength">The max possible length the random name should be</param>
        /// <returns>A random name. The creator of this algorithm takes no responsibility for the content that
        /// may be generated, this is a random simulation. Consider using an word filter to remove 
        /// undesirable content</returns>
        public static string NextName(int maxLength)
        {
            Random r = new Random();
            //chose a random name length and make sure maxLength is longer than 3
            int nameLength = r.Next(3, maxLength <= 3 ? 4 : maxLength + 1);

            //create a list of consonant sounds
            string[] consonants = new string[] { "b", "c", "d", "f", "g", "h", "j", "k",
            "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };

            //create a base list of vowels
            string[] vowels = new string[] { "a", "e", "i", "o", "u", "y" };

            //let's make it spicy by combining every vowel with every other vowel
            string[] spicyVowels = new string[vowels.Length * vowels.Length];

            int index = 0;

            for(int i = 0; i < vowels.Length; i++)
            {
                for(int j = 0; j < vowels.Length; j++)
                {
                    spicyVowels[index] = vowels[i] + vowels[j];
                    index++;
                }
            }

            //Start building the name
            string randName = "";

            //~30% chance name will start with spicy vowels
            if (r.NextDouble() < 0.30)
            {
                //Add from the list of spicy vowels
                string temp = spicyVowels[r.Next(spicyVowels.Length)];

                //Capitalize the first letter
                randName = temp.Substring(0, 1).ToUpper() + temp.Substring(1);
            }
            else
            {
                //Add from the array of consonants
                randName = consonants[r.Next(consonants.Length)].ToUpper();
            }

            //Add from the array of spicy vowels 
            //TODO if already added spicy vowels make consonant, if already consonant add
            //spicy or regular vowel
            randName += spicyVowels[r.Next(spicyVowels.Length)];

            //Loop over
            while (randName.Length < nameLength)
            {
                //If the last character is in the consonants array, time to add a vowel
                if (consonants.Contains(randName.Substring(randName.Length - 1)))
                {
                    //~30% chance name to add spicy vowels
                    if (r.NextDouble() < 0.30)
                    {
                        //Add from the array of spicy vowels
                        randName += spicyVowels[r.Next(spicyVowels.Length)];
                    }
                    else //otherwise, add a regular vowel
                    {
                        //Add from the array of vowels
                        randName += vowels[r.Next(vowels.Length)];
                    }
                }
                else //otherwise add,a consonant
                {
                    //Add from the list of consonants
                    randName += consonants[r.Next(consonants.Length)];
                }
            }

            return randName;
        }
    }
}
