using System;

namespace MyPractice // namespace is used to organize code and prevent naming conflicts, it's a organizer for classes and other types
{
    internal class Program // internal keyword limits access to this class within the same assembly(same project), default for classes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // Console.WriteLine is used to print text to the console
                                               // in System namespace it has Console class with WriteLine method
            
            byte number = 25; // byte is a data type that can hold whole numbers from 0 to 255
            Console.WriteLine(number); 

            float pi = 3.14f; // float is a data type that can hold decimal numbers, 'f' suffix indicates it's a float literal
            Console.WriteLine(pi); 

            char character = 'A'; // char is a data type that holds a single character, enclosed in single quotes
            Console.WriteLine(character); 

            string name = "Meltem"; // string is a data type that holds a sequence of characters, enclosed in double quotes
            Console.WriteLine(name);

            bool isitRunning = true; // bool is a data type that holds either true or false
            Console.WriteLine(isitRunning);

            var car = "Honda"; // var keyword allows the compiler to infer the type of the variable from the assigned value
            Console.WriteLine(car);

            Console.WriteLine("{0} {1} {2} {3} {4} {5}", number, pi, character, name, isitRunning, car); // formatted string output using placeholders
            Console.WriteLine("{0}, {1}", byte.MinValue, float.MaxValue); // displaying minimum and maximum values of byte and float data types

            const float Pi = 3.14f; // const keyword is used to declare a constant variable whose value cannot be changed after initialization
            // Pi = 3.15f; // This line would cause a compile-time error because Pi is a constant
            Console.WriteLine(Pi);


            // Implicit Conversion örneği
            byte a = 100;
            int b = a; // byte to int conversion is implicit because int can hold all values
            Console.WriteLine(b);

            /* Explicit Conversion gerekliliğinin örneği
            int num = 300;
            byte i = num; // This line would cause a compile-time error because 300 is outside the range of byte (0-255)
            Console.WriteLine(i);
            */
            int num = 300;
            byte i = (byte)num; // Explicit conversion (casting) from int to byte

            // non-compatible type conversion örneği
            float f = 3.14f;
            int c = (int)f; // Explicit conversion from float to int, fractional part is truncated

            try
            {
                var numb = "1234";
                byte n = Convert.ToByte(numb);
                Console.WriteLine(n);
            }
            catch (Exception)
            {
                Console.WriteLine("Sayı byte'a dönüştürülemedi.");
            }


            try
            {
                string str = "true";
                bool boolean = Convert.ToBoolean(str);
                Console.WriteLine(boolean);
            }
            catch (Exception)
            {
                Console.WriteLine("Sayı byte'a dönüştürülemedi.");
            }

        }
    }
}