namespace _4_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring variable
            int num1;
            // assigning a value to a variable
            num1 = 13;
            //declaring and initializing
            int num2 = 23;
            int sum = num1 + num2;
            Console.WriteLine(num1 + "+" + num2 + "=" + sum);

            // declaring multiple variables at once
            int num3, num4, num5;

            //precise
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine(d1 + "/" + d2 + "=" + dDiv);

            // less precise (less memory useage)
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine(f1 + "/" + f2 + "=" + fDiv);

            double dIDiv = f1 / num1;
            Console.WriteLine(d1 + "/" + num1 + "=" + dIDiv);

            Console.Read();
        }
    }
}