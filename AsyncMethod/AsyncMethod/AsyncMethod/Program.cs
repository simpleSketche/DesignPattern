using System;
using System.Threading.Tasks;

namespace AsyncMethod
{
    class Program
    {
        private string awesome = "awesome";
        private string awesome1 = "awesome1";

        public string Awesome
        {
            get { return awesome; }
            set
            {
                Console.WriteLine($"{DateTime.Now} Enter Awesome setter");
                awesome = value;
                AwesomeSideEffect();
                Console.WriteLine($"{DateTime.Now} Exit Awesome setter");
            }
        }

        public string Awesome1
        {
            get { return awesome1; }
            set
            {
                Action sideEffect = async () =>
                {
                    await Task.Delay(3000);
                    Console.WriteLine($"{DateTime.Now} Awesome1 side-effect");
                };

                Console.WriteLine($"{DateTime.Now} Enter Awesome1 setter");
                awesome1 = value;
                sideEffect();
                Console.WriteLine($"{DateTime.Now} Exit Awesome1 setter");
            }
        }

        private async void AwesomeSideEffect()
        {
            await Task.Delay(6000);
            Console.WriteLine($"{DateTime.Now} Awesome side-effect");
        }

        static void Main(string[] args)
        {
            var program = new Program();
            program.Awesome = "Demo";
            Console.WriteLine();
            program.Awesome1 = "Set";
            System.Threading.Thread.Sleep(10000);
            Console.ReadLine();
        }
    }
}
