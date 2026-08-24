internal class Session2
{
    private static void Bleee(string[] args)
    { // to Add/Sum Two numbers
        Console.WriteLine(" Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" The answer is: " + (num1 + num2));
        // To swap two variables
        int a = 10;
        int b = 20;
        Console.WriteLine("Before: a = {0}, b = {1}", a, b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After: a = {0}, b = {1}", a, b);
        // to multiply two floating point numbers
        Console.WriteLine("Enter the first floating point number: ");
        float fnum1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the second floating point number: ");
        float fnum2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("The answer is: " + (fnum1 * fnum2));
        //to convert feet to meter
        Console.WriteLine("Enter the length in feet: ");
        float feet = Convert.ToSingle(Console.ReadLine());
        float meters = feet * 0.3048f;
        Console.WriteLine($"{feet} feet is equal to {meters} meters");
        // to convert Celsius to Fahrenheit
        Console.WriteLine("Enter the temperature in Celsius: ");
        float celsius = Convert.ToSingle(Console.ReadLine());
        float fahrenheit = (celsius * 9/5) + 32;
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        // to convert Fahrenheit to Celsius
        Console.WriteLine("Enter the temperature in Fahrenheit: "); 
        float fahrenheitInput = Convert.ToSingle(Console.ReadLine());
        float celsiusOutput = (fahrenheitInput - 32) * 5/9;
        Console.WriteLine($"{fahrenheitInput}°F is equal to {celsiusOutput}°C");
        //to find the size of data types
        Console.WriteLine("Size of data types:");
        Console.WriteLine($"Size of int: {sizeof(int)} bytes");
        Console.WriteLine($"Size of float: {sizeof(float)} bytes");
        Console.WriteLine($"Size of double: {sizeof(double)} bytes");
        Console.WriteLine($"Size of char: {sizeof(char)} bytes");
        Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");
        Console.WriteLine($"Size of long: {sizeof(long)} bytes");
        Console.WriteLine($"Size of short: {sizeof(short)} bytes");
        Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
        Console.WriteLine($"Size of decimal: {sizeof(decimal)} bytes");
        // to print ASCII Value
        Console.WriteLine(" Enter a character:");
        int c= Console.Read();
        Console.WriteLine($"The ASCII value of the character is: {c}" );
        // to Calculate the area of a circle
        Console.WriteLine(" Enter the radius of the cirle:");
        float radius = Convert.ToSingle(Console.ReadLine());
        float area = 3.14f * radius * radius;
        Console.WriteLine($"The area of the circle is: {area}");
        // to calculate the area of a square
        Console.WriteLine(" Enter the side length of the square:");
        float side = Convert.ToSingle(Console.ReadLine());
        float squareArea = side * side;
        Console.WriteLine($"The area of the square is: {squareArea}");
        // to convert day to years, weeks and days
        Console.WriteLine(" Enter the number of days: ");
        int Days = Convert.ToInt32(Console.ReadLine());
        int years = Days / 365;
        int weeks = (Days - years * 365) / 7;
        int remainingDays = Days - (years * 365 + weeks * 7);
        Console.WriteLine($"{Days} days is equal to {years} years, {weeks} weeks, and {remainingDays} days.");
    }



}