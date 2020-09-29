using RudeTongueTester.Controllers;
using RudeTongueTester.IO.Reader;
using RudeTongueTester.IO.Writer;
using RudeTongueTester.Solvers;
using SimpleInjector;

namespace RudeTongueTester.CLI
{
    public static class StartUp
    {
        public static Container Container;

        public static Container ConfigureServices()
        {
            Container = new Container();

            Container.Register<IWriter, Writer>();
            Container.Register<IReader, Reader>();
            Container.Register<ISolver, Solver>();
            Container.Register<Controller>();

            Container.Verify();

            return Container;
        }
    }
}
