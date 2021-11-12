using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Sample.MVVM;

namespace Sample.ViewModels
{
    public class MainViewModels : BaseViewModel
    {
        public string MyText { get; set; }
        public int Counter { get; set; }
        public ICommand CountUpCommand { get; set; }
        public MainViewModels()
        {
            this.Counter = 0;
            this.CountUpCommand = new RelayCommand(this.CountUp);
        }

        public void CountUp()
        {
            this.Counter += 1;
        }
    }
}
