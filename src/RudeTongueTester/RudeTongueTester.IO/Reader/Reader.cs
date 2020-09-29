using System;

namespace RudeTongueTester.IO.Reader
{
    public class Reader : IReader
    {
        public string Read()
            => Console.ReadLine();
    }
}
