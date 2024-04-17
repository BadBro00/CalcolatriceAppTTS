using System;
using Android.OS;
using Android.Speech.Tts;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MyMvvmCrossApp1.Core.ViewModels.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMvvmCrossApp1.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class HomePage : MvxContentPage<HomeViewModel>
    {
        TextToSpeech Speech = new TextToSpeech(Android.App.Application.Context, null);
        public HomePage()
        {
            InitializeComponent();
        }

        public void Speak(string txt)
        {
            Speech.Speak(txt,QueueMode.Flush,null,null);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.BarTextColor = Color.White;
                navigationPage.BarBackgroundColor = (Color)Application.Current.Resources["PrimaryColor"];
            }
        }
        private void Click9(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;

            if (currentText == "0")
            {
                NumEntry.Text = "9";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "9";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void Click8(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;

            if (currentText == "0")
            {
                NumEntry.Text = "8";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "8";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void Click7(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;

            if (currentText == "0")
            {
                NumEntry.Text = "7";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "7";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void Click6(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;

            if (currentText == "0")
            {
                NumEntry.Text = "6";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "6";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void Click5(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;
            if (currentText == "0")
            {
                NumEntry.Text = "5";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "5";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void Click4(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;

            if (currentText == "0")
            {
                NumEntry.Text = "4";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "4";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void Click3(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;

            if (currentText == "0")
            {
                NumEntry.Text = "3";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "3";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void Click2(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;

            if (currentText == "0")
            {
                NumEntry.Text = "2";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "2";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void Click1(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;

            if (currentText == "0")
            {
                NumEntry.Text = "1";
                Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
            else
            {
                NumEntry.Text += "1";
                //Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
            }
        }
        private void sum(int a)
        {
            
        }
        private void diff(int a)
        {

        }
        private void PlusClick(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;
            sum(int.Parse(NumEntry.Text));
            NumEntry.Text = "+";
            Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
        }
        private void MinusClick(object sender, EventArgs e)
        {
            var currentText = NumEntry.Text;
            diff(int.Parse(NumEntry.Text));
            NumEntry.Text = "-";
            Speech.Speak(NumEntry.Text, QueueMode.Flush, null, null);
        }
    }
}
