namespace _4m05_kalkulator
{
    public partial class MainPage : ContentPage
    {
        private string wynik = "0";
        bool czyObliczone = true;
        public MainPage()
        {
            InitializeComponent();
        }

        private void On1Clicked(object sender, EventArgs e)
        {
            if(czyObliczone)
            {
                wynik = "1";
                czyObliczone = false;
            }
            else
                wynik += "1";
                
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On2Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "2";
                czyObliczone = false;
            }
            else
                wynik += "2";
            wynikLbl.Text = wynik; 
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On3Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "3";
                czyObliczone = false;
            }
            else
                wynik += "3";
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On4Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "4";
                czyObliczone = false;
            }
            else
                wynik += "4";
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On5Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "5";
                czyObliczone = false;
            }
            else
                wynik += "5";
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On6Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "6";
                czyObliczone = false;
            }
            else
                wynik += "6";
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On7Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "7";
                czyObliczone = false;
            }
            else
                wynik += "7";
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On8Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "8";
                czyObliczone = false;
            }
            else
                wynik += "8";
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On9Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "9";
                czyObliczone = false;
            }
            else
                wynik += "9";
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On0Clicked(object sender, EventArgs e)
        {
            if (czyObliczone)
            {
                wynik = "0";
                czyObliczone = false;
            }
            else
                wynik += "0";
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
 
        private void OnPMClicked(object sender, EventArgs e)
        {

        }
        private void OnPrzecClicked(object sender, EventArgs e)
        {

        }
        private void OnEnterClicked(object sender, EventArgs e)
        {
        }
        private void OnPlusClicked(object sender, EventArgs e)
        {

        }
        private void OnMinusClicked(object sender, EventArgs e)
        {

        }
        private void OnRazyClicked(object sender, EventArgs e)
        {

        }
        private void OnDzielClicked(object sender, EventArgs e)
        {

        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            wynik = "0";
            czyObliczone = true;
            wynikLbl.Text = wynik;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
    }
}