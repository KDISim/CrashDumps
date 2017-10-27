namespace Crash
{
    class Program
    {
        static void Main()
        {
            var crash = new OffWeGo();
            crash.Bang();

        }
    }

    class OffWeGo
    {
        public void Bang()
        {
            Bang();
        }
    }
}
