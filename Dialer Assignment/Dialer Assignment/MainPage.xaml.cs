using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dialer_Assignment
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var enteredNumber = (sender as Button).Text;
            if (enteredNumber == "C")
            {
                if(this.phoneNumber.Text.Length > 0)
                {
                    this.phoneNumber.Text = this.phoneNumber.Text.Remove(this.phoneNumber.Text.Length - 1);
                }
            }
            else
            {
                this.phoneNumber.Text += enteredNumber;
            }
        }
    }
}
