using System;

namespace RudeTongueTester.IO.Writer
{
    public class Writer : IWriter
    {
        public void Write(string args)
            => Console.WriteLine(this.FormatOutput(args));

        private string FormatOutput(string output)
        {
            return output switch
            {
                "1" => "This text is \"rude\".",
                "0" => "This text is not \"rude\".",
                _ => "Error"
            };
        }
    }
}
