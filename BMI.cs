using System;
namespace BMI_index
{
    internal class BMI
    {
        float height;
        float weight;
        float bmi;
        // constructor
        public BMI(float height)
        {
            this.height = (height/100);
        }
        // Constructor OverLoading and Constructor Chaining.
        public BMI(float height, float weight) : this(height)
        {
            this.weight = weight;
        }

        public void GetBMI()
        {
            bmi = weight / (height * height);

            // Boxing
            object boxedBMI = bmi;

            Console.WriteLine("Boxed BMI value: " + boxedBMI);

            // Unboxing
            float unboxedBMI = (float)boxedBMI;

            Console.WriteLine("Unboxed BMI value: " + unboxedBMI);
        }

    }
}
