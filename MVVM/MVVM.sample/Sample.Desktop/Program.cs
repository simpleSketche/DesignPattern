using System;
using Sample.UI;

namespace Sample.Desktop
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var myMainWindow = new MainView();
            myMainWindow.ShowDialog();
        }
    }
}
