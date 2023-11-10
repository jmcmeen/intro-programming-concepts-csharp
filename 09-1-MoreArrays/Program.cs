namespace _09_1_MoreArrays
{
    internal class Program
    {
        static void Main()
        {
            int arraySize = Prompt.ForInt("How many grades do you want to enter: ");

            if (arraySize <= 0)
            {
                Console.WriteLine("Need to specify 1 or more grades: ");
                return;
            }

            float[] grades = new float[arraySize];

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Prompt.ForFloat($"Enter grade: ");
            }

            float gradeAverage = CalculateAverage1(grades);

            Console.WriteLine(gradeAverage);

            Console.WriteLine();
        }

        public static float CalculateAverage1(float[] floats)
        {
            float total = 0.0f;
            float average;

            //Total up all values in array
            for (int i = 0; i < floats.Length; i++)
            {
                total += floats[i];

            }

            //Calculate average
            average = total / floats.Length;

            //Return average
            return average;
        }

        public static float CalculateAverage2(float[] floats)
        {
            float total = 0.0f;
            float average;

            //Total up all values in array
            foreach (float f in floats)
            {
                total += f;
            }

            //Calculate average
            average = total / floats.Length;

            //Return average
            return average;
        }
    }
}