namespace _11_String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            string name = "Jimmy";

            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old.");

            // String formatting
            Console.WriteLine("Hello my name is {0}, I am {1} years old.", name, age);

            // String interpolation
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.");

            // Verbatim strings
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit,
sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim 
veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo 
consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum 
dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, 
sunt in culpa qui officia deserunt mollit anim id est laborum.");

            // Verbatim is good in cases where there are "\" involved
            Console.WriteLine(@"C:\Program Files (x86)");

        }
    }
}