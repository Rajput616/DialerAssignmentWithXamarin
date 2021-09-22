using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dialer_Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageAssignment : ContentPage
    {

        private int id = 1;
        public ImageAssignment()
        {
            InitializeComponent();
            imageView.Source = "http://lorempixel.com/1920/1080/city/" + id + "/";        
        }

        private void Button_Clicked_Left(object sender, EventArgs e)
        {
            if(id == 1)     // 1 2 3 4 5 6 7 8 9 10
            {
                id = 10;
            }
            else
            {
                id = id - 1;
            }
            imageView.Source = "http://lorempixel.com/1920/1080/city/" + id + "/";
        }

        private void Button_Clicked_Right(object sender, EventArgs e)
        {
            if(id == 10)
            {
                id = 1;
            }
            else
            {
                id = id + 1;
            }
            imageView.Source = "http://lorempixel.com/1920/1080/city/" + id + "/";
        }
    }
}