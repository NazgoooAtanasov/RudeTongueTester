namespace RudeToungeTester.Controller
{
    using RudeToungeTester.IO.Reader;
    using RudeToungeTester.IO.Writer;
    using RudeToungeTester.Solver;

    public class Controller : IController
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;
        private readonly ISolver _solver;

        public Controller(IReader reader, IWriter writer, ISolver solver)
        {
            this._reader = reader;
            this._writer = writer;
            this._solver = solver;
        }

        public void Execute()
        {
            var text = this._reader.Read();

            var prediction = this._solver.Solve(text);

            this._writer.Write(prediction);
        }
    }
}
