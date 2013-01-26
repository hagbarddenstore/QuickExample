namespace Application
{
    using System;

    using Library;

    public class Component : IComponent
    {
        public void DoStuff()
        {
            Console.WriteLine("This is the Application implementation!");
        }
    }
}