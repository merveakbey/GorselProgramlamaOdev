namespace ödev2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        private async void OnKrediHesaplamaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KrediHesaplamaPage());
        }

        
        private async void OnVkiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VucutKitleIndeksiPage());
        }

        
        private async void OnRenkSeciciClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RenkSeciciPage());
        }

       
        private async void OnYapilacaklarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YapilacaklarPage());
        }
    }
}
