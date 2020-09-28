using RudeToungeTester.Controllers;
using RudeToungeTester.IO.Reader;
using RudeToungeTester.IO.Writer;
using RudeToungeTester.Solvers;
using SimpleInjector;

namespace RudeToungeTester.CLI
{
    public static class StartUp
    {
        public static Container _container;

        public static Container ConfigureServices()
        {
            _container = new Container();

            _container.Register<IWriter, Writer>();
            _container.Register<IReader, Reader>();
            _container.Register<ISolver, Solver>();
            _container.Register<Controller>();

            _container.Verify();

            return _container;
        }
    }
}
