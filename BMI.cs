using System;
namespace BMI_index
{
    internal class BMI
    {
        float height;
        float weight;
        float bmi;

        public BMI(float height)
        {
            this.height = (height/100);
        }

        public BMI(float height, float weight) : this(height)
        {
            this.weight = weight;
        }

        public void GetBMI()
        {
            bmi = weight / (height * height);
            Console.WriteLine("Your BMI is: " + bmi);
        }

    }
}
