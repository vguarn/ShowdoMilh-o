using ShowdoMilhão.Models;

namespace ShowdoMilhão
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao = "GASOSO" },
                    new Alternativa { Correta = false, Descricao = "VAPOROSO"}
                }
            },

            new Pergunta
            {
                Id = 2,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Marechal Deodoro"},
                    new Alternativa { Correta = false, Descricao = "Marquês de Pombal" },
                    new Alternativa { Correta = false, Descricao = "Duque de Caixias" },
                    new Alternativa { Correta = false, Descricao = "Barão de Mauá" }
            },

            new Pergunta
            {
                Id = 3, 
                Enunciado = "Qual é o santo casamenteiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "São Pedro" },
                    new Alternativa { Correta = false, Descricao = "São Paulo" },
                    new Alternativa { Correta = true, Descricao = "Santo Antônio" },
                    new Alternativa { Correta = false, Descricao = "São João" }
                },
            

        };



        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
