# Console Methods

* Console.Write("text here") - Prints and keeps the cursor on the same line
* Console.WriteLine("text here") - Prints and puts the cursor on the next line
* Console.Read() - Takes a single input of type string and it returns the [ASCII](https://www.ascii-code.com) value of that input
* Console.ReadLine() - Takes a string or integer input and returns it as the Output value

```cs
static void Main (string[] args) {
  Console.Write("Enter a string and press enter :");
  string readInput = Console.ReadLine();
  Console.WriteLine("You have entered {0}",readInput)
}
```

* Console.ReadKey() - Takes a single input of type string and it returns the Key info
