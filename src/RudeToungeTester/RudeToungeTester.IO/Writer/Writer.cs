namespace RudeToungeTester.IO.Writer
{
    using System;

    public class Writer : IWriter
    {
        public void Write(string args)
            => Console.WriteLine(args);
    }
}
