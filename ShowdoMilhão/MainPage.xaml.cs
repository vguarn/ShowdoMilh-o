using Metal;

namespace ShowdoMilhão
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        double premio = 1000;
        int pergunta_count = 1;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = App.getRandowPerguntaFacil();

            lbl_nivel.Text = "Fácil";
            lbl_premio.Text = premio.ToString("C");
            lbl_pergunta_numero.Text = pergunta_count.ToString();
        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandowPerguntaFacil();
        }

        private async void Button_Clicked_Proxima(object sender, EventArgs e)
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
                    resp = alt3.Content.ToString();
                }
            }

            if (acertou)
            {
                DisplayAlert("ACERTOU!", resp, "OK");
                pergunta_count++;
                avanca_pergunta();
            }
            else
            {
                DisplayAlert("ERROU!", "Você perdeu", "OK");
            }

        }

        void avanca_pergunta()
        {
            if (pergunta_count <= 5)
            {
                premio = premio + 1000;
                this.BindingContext = App.getRandowPerguntaFacil();
                lbl_nivel.Text = "Fácil";
            }

            if (pergunta_count > 5 && pergunta_count <= 15)
            {
                premio = premio + 10000;
                this.BindingContext = App.getRandowPerguntaMedia();
                lbl_nivel.Text = "Média";
            }

            if(pergunta_count > 10 && pergunta_count <15)
            {
                premio = premio + 100000;
                this.BindingContext = App.getRandowPerguntaDificil();
                lbl_nivel.Text = "Difícil";
            }
        }

    }

     


        
}
