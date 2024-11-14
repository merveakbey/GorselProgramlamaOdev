using System;
using Microsoft.Maui.Controls;

namespace ödev2
{
    public partial class KrediHesaplamaPage : ContentPage
    {
        public KrediHesaplamaPage()
        {
            InitializeComponent();
        }

        private void OnHesaplaClicked(object sender, EventArgs e)
        {
            try
            {
                
                double krediTutari = Convert.ToDouble(KrediTutariEntry.Text);
                double faizOrani = Convert.ToDouble(FaizOraniEntry.Text);
                int vade = Convert.ToInt32(VadeEntry.Text);

                
                double kkdf = 0.15;  
                double bsmv = 0.10;  
                double brutFaiz = (faizOrani + faizOrani * bsmv + faizOrani * kkdf) / 100;

                
                double aylikTaksit = (Math.Pow(1 + brutFaiz, vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, vade) - 1) * krediTutari;

                
                double toplamOdeme = aylikTaksit * vade;
                double toplamFaiz = toplamOdeme - krediTutari;

                
                AylikTaksitLabel.Text = $"₺{aylikTaksit:F2}";
                ToplamOdemeLabel.Text = $"₺{toplamOdeme:F2}";
                ToplamFaizLabel.Text = $"₺{toplamFaiz:F2}";
            }
            catch (Exception ex)
            {
                
                DisplayAlert("Hata", "Lütfen geçerli bir değer giriniz.", "Tamam");
            }
        }



        private async void GoToVucutKitleIndeksiPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//VucutKitleIndeksiPage");
        }
    }
}
