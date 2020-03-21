using System;
using System.ComponentModel;
using System.Threading;
using Xamarin.Forms;

namespace gaweHelloXamarinWorld
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int _count;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CountUp(object sender, EventArgs e)
        {
            if (_count == 0)
                await DisplayAlert("Button pressed", "You pressed the button and executed an increase.", "Ok");
            Interlocked.Increment(ref _count);
            ((Button)sender).Text = $"You clicked {_count} times.";
        }
    }
}
