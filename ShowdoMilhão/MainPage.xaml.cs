namespace ShowdoMilhão
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_Proxima(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ((bool)alt0.Value)
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                }

            }

            if (alt1.IsChecked)
            {
                if((bool)alt1.Value)
                {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }

            if (alt2.IsChecked)
            {
                if((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }

            if (alt3.IsChecked)
            {
                if((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt33.Content.ToString();
                }
            }

            if (acertou)
            {
                DisplayAlert("ACERTOU!", resp, "OK");
                this.BindingContext = App.getRandowPerguntaFacil();
            }
            else
            {
                DisplayAlert("ERROU!", "Você perdeu", "OK");
            }

        }

    }


        
}
