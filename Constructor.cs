namespace POC
{
    internal class Con
    {
        public int n;
        public string? name;


        // Constructor
        public Con()
        {
            n = 0;
            Console.WriteLine("Default Constructor called");

        }


        // Constructor overloading Where the Parameter are different.

        public Con(int n) 
        {
            this.n = n;
            Console.WriteLine("Constructor called");
        }

        // Constructor Chaining is Process of calling another constructor from a constructor 
        // here, Con(n) is calling when the Con(int n, string name) is called
        // first Con(int n) is called then the current constructor

        public Con(int n, string name) : this(n)
        {
            this.name = name;
            Console.WriteLine("Con(n,name) is Called");
        }

    }
}
