using RudeTongueTester.IO.Reader;
using RudeTongueTester.IO.Writer;
using RudeTongueTester.Solvers;

namespace RudeTongueTester.Controllers
{
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
