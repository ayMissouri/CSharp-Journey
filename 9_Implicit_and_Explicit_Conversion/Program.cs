namespace _9_Implicit_and_Explicit_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;


            // explicit conversion
            double myDouble = 13.37;
            int myInt;
            // cast double to int
            myInt = (int)myDouble;
            Console.WriteLine(myInt);


            // typeConversion
            string myString = myDouble.ToString();
            myFloat.ToString();
        }
    }
}