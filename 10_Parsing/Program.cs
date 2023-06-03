namespace _10_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int result = num2 + num1;

            Console.WriteLine(result);

            string stringForFloat = "0.85";
            string stringForInt = "12345";
            
            float myfloat = float.Parse(stringForFloat);
            int myInt = Int32.Parse(stringForInt);
            Console.WriteLine(myInt + " " + myfloat);
        }
    }
}