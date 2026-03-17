namespace POC
{
    class Program
    {
        public static void Main(string[] args)
        {
            // POC for the Boxing and UnBoxing
            // Boxing
            int num = 10;

            object obj = num;

            Console.WriteLine("After Boxing: ");
            Console.WriteLine("Value: "+obj);

            // unboxing 
            int newNum = (int)obj;

            Console.WriteLine("\nAfter Unboxing");
            Console.WriteLine("Value: "+ newNum);

            // POC on Constructor and Constructor overloading

            Con con1 = new Con();

            // Output: 
            // Default Constructor called

            Con con2 = new Con(3);

            // Output:
            // Constructor called

            Con con3 = new Con(4,"mohan");

            // Output:
            // Constructor called
            // Con(n,name) is Called

        }
    }
}