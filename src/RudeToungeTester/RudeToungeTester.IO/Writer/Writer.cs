using System;

namespace RudeTongueTester.IO.Writer
{
    public class Writer : IWriter
    {
        public void Write(string args)
            => Console.WriteLine(args);
    }
}
