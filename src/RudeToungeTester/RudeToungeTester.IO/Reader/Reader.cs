namespace RudeToungeTester.IO.Reader
{
    using System;
    public class Reader : IReader
    {
        public string Read()
            => Console.ReadLine();
    }
}
