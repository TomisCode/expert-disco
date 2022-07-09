using System;

namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myInt = -123456789;
            Console.WriteLine(myInt);
            uint myUint = 123456;
            Console.WriteLine(myUint);
            short myShort = -32456;
            Console.WriteLine(myShort);
            ushort myUshort = 65535;
            Console.WriteLine(myUshort);
            float myFloat = -31.678F;
            Console.WriteLine(myFloat);
            double myDouble = -12.456;
            Console.WriteLine(myDouble);
            char myCharacter = 'A';
            bool myBoolean = false;
            Console.WriteLine(myBoolean);
            Console.WriteLine(myCharacter);
            string myText = ("I control this text");
            Console.WriteLine(myText);
            string numText = "15";
            
            int myNumfromText = int.Parse(numText); 
            Console.WriteLine(myNumfromText);
            Console.ReadLine();

        }
    }
}
