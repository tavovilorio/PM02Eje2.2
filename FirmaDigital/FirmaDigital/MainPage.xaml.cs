using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignaturePad.Forms;
using Xamarin.Forms;

namespace FirmaDigital
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonGuardar_Clicked(object sender, EventArgs e)
        {
           Stream image = await PadView.GetImageStreamAsync(SignatureImageFormat.jpg);
        }

        private void ButtonClear_Clicked(object sender, EventArgs e)
        {
            PadView.Clear();
        }

    }
}
