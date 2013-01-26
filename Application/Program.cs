namespace Application
{
    using System;

    using Library;

    public class Program
    {
        public static void Main()
        {
            var component = new Component();

            var consumer = new Consumer(component);

            consumer.DoStuff();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
