using System;

namespace StringMani
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // DEFINE NEW VARIABLES
            int age = 20;
            string name = "Tomi";
            string job = "Developer";

            // 1 st string concatenation

            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old.");

            // 2 nd String Formatting
            // string formatting uses index 
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old. I am a {2}.", name, age, job);

            // 3 rd String Interpolation
            // starts with $, can write variables like {name}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, my name is {name} , I am {age} years old. I am a {job}.", name, age, job);

            // 4 th Verbatim Strings
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus eget leo pretium, facilisis diam nec, tempor ex. Maecenas quis arcu vestibulum, 
consequat velit at, efficitur tellus. Nullam vel libero sed ligula suscipit mattis. Proin condimentum ipsum vel aliquet porta. Sed varius vehicula lectus, in dignissim enim laoreet 
a. Pellentesque ornare mi ut dolor dignissim posuere. Nulla lobortis diam ultricies, fermentum nibh ut, posuere quam. Etiam rhoncus accumsan felis, ut tempor magna bibendum eget. 
Donec id nulla tincidunt, tristique diam sit amet, molestie arcu.

Nunc nibh lorem, iaculis accumsan urna sit amet, tristique scelerisque est. Morbi posuere et lacus sed interdum. Suspendisse vitae odio non diam convallis viverra sed ut nulla. 
Integer ultrices tortor tempor mi tincidunt, sed blandit purus interdum. In quis enim efficitur, auctor erat a, dapibus felis. Orci varius natoque penatibus et magnis dis parturient 
montes, nascetur ridiculus mus. Duis laoreet a justo in porttitor. Sed consectetur, odio vitae ornare dapibus, eros lectus consequat ipsum, quis sagittis turpis mauris vitae est. 
In hendrerit, erat eu elementum condimentum, magna tellus tempor nisl, non dignissim dui sem sed augue. Aliquam erat volutpat. Integer hendrerit luctus arcu sit amet tempor. 
Phasellus dignissim ullamcorper erat sagittis suscipit. Duis sit amet erat semper, imperdiet quam eu, iaculis enim."
                                                        );
            Console.WriteLine(@"C:\Users\anddy\Pictures\1932map.png");

        }
    }
}
