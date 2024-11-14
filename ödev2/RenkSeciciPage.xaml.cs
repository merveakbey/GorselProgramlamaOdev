
using System;
using Microsoft.Maui.Controls;

namespace ödev2
{
    public partial class RenkSeciciPage : ContentPage
    {
        public RenkSeciciPage()
        {
            InitializeComponent();
            UpdateColor(); 
        }

        
        private void OnColorSliderChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateColor();
        }

        
        private void UpdateColor()
        {
            
            int red = (int)RedSlider.Value;
            int green = (int)GreenSlider.Value;
            int blue = (int)BlueSlider.Value;

            
            string hexColor = $"#{red:X2}{green:X2}{blue:X2}";
            ColorCodeEntry.Text = hexColor;

            
            ColorPreview.Color = Color.FromRgb(red, green, blue);
        }

       
        private async void OnCopyColorCodeClicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(ColorCodeEntry.Text);
            await DisplayAlert("Kopyalandı", $"{ColorCodeEntry.Text} kopyalandı!", "OK");
        }

     
        private void OnRandomColorClicked(object sender, EventArgs e)
        {
            var random = new Random();
            RedSlider.Value = random.Next(0, 256);
            GreenSlider.Value = random.Next(0, 256);
            BlueSlider.Value = random.Next(0, 256);
        }
    }
}
