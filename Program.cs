namespace BMI_index
{
    class Program
    {
        public static void Main(string[] args)
        {
            float height, weight;
            Console.WriteLine("Enter Height (CM)");
            while (true)
            {
                if (!float.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Enter correct Height");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Enter weight");
            while (true)
            {
                if (!float.TryParse(Console.ReadLine(), out weight))
                {
                    Console.WriteLine("Enter correct Weight");
                }
                else
                {
                    break;
                }
            }
            BMI bmi = new BMI(height, weight);

            bmi.GetBMI();
        }
    }
}