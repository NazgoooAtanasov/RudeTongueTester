using RudeTongueTester.Controllers;

namespace RudeTongueTester.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = StartUp.ConfigureServices();

            var controller = container.GetInstance<Controller>();

            controller.Execute();
        }
    }
}
