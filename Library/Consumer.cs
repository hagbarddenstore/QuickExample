namespace Library
{
    public class Consumer
    {
        private readonly IComponent _component;

        public Consumer(IComponent component)
        {
            _component = component;
        }

        public void DoStuff()
        {
            _component.DoStuff();
        }
    }
}