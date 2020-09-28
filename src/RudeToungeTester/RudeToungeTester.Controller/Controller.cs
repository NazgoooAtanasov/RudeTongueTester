namespace RudeToungeTester.Controllers
{
    using RudeToungeTester.IO.Reader;
    using RudeToungeTester.IO.Writer;
    using RudeToungeTester.Solvers;

    public class Controller : IController
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;
        private readonly ISolver _solver;

        public Controller(IReader reader, IWriter writer, ISolver solver)
        {
            _reader = reader;
            _writer = writer;
            _solver = solver;
        }

        public void Execute()
        {
            var text = _reader.Read();

            var prediction = _solver.Solve(text);

            _writer.Write(prediction);
        }
    }
}
