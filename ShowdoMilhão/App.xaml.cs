using Microsoft.CSharp.RuntimeBinder;
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
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                    new Alternativa { Correta = false, Descricao = "MARQUÊS DE POMBAL" },
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAIXIAS" },
                    new Alternativa { Correta = false, Descricao = "BARÃO DE MAUÁ" }
            },

            new Pergunta
            {
                Id = 3, 
                Enunciado = "Qual é o santo casamenteiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SÃO PEDRO" },
                    new Alternativa { Correta = false, Descricao = "SÃO PAULO" },
                    new Alternativa { Correta = true, Descricao = "SANTO ANTÔNI" },
                    new Alternativa { Correta = false, Descricao = "SÃO JOÃO" }
                },

            new Pergunta
            {
                Id= 4, 
                Enunciado = "Quem é a esposa do Mickey?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARGARIDA" },
                    new Alternativa { Correta = true, Descricao = "MINNIE" },
                    new Alternativa { Correta = false, Descricao = "A PEQUENA SEREIA" },
                    new Alternativa { Correta = false, Descricao = "OLÍVIA PALTO" }

            },

            new Pergunta 
            { 
                Id= 5,
                Enunciado = "Quem foi o amor do imperador Marco Antônio?",
                Alternativas = new()
                {
                 new Alternativa { Correta = false, Descricao = "SHERAZADE" },
                 new Alternativa { Correta = false, Descricao = "LADY GODIVA" },
                 new Alternativa { Correta = true, Descricao = "CLEÓPATRA" },
                 new Alternativa { Correta = false, Descricao = "JULIETA" }
                },

            new Pergunta
            {
                Id = 6, 
                Enunciado = "O violoncelo é um instrumento de? ",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SOPRO" },
                    new Alternativa { Correta = true, Descricao = "CORDA" },
                    new Alternativa { Correta = false, Descricao = "PERCUSSÃO" },
                    new Alternativa { Correta = false, Descricao = "REPERCUSSÃO" }
                }
            },

            new Pergunta
            {
                Id = 7, 
                Enunciado = "Quem fundou a Microsoft?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "BILL GATES" },
                    new Alternativa { Correta = false, Descricao = "PRINCÍPE CHARLES" },
                    new Alternativa { Correta = false, Descricao = "AKIO MORITA" },
                    new Alternativa { Correta = false, Descricao = "SULTÃO DE BRUNEI" }
                }
            },

            new Pergunta
            {
                Id = 8,
                Enunciado = "Quantas dentinções naturais tem o ser humano?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "UMA" },
                    new Alternativa { Correta = true, Descricao = "DUAS" },
                    new Alternativa { Correta = false, Descricao = "TRÊS" },
                    new Alternativa { Correta = false, Descricao = "QUATRO" }
                }
            },

            new Pergunta 
            {
                Id = 9,
                Enunciado = "Quantas folhas tem um trevo da sorte?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRÊS" },
                    new Alternativa { Correta = true, Descricao = "QUATRO" },
                    new Alternativa { Correta = false, Descricao = "CINCO" },
                    new Alternativa { Correta = false, Descricao = "SEIS" }
                }
            },

            new Pergunta 
            {
                Id = 10,
                Enunciado = "Qual é a cidade que é conhecida como: terra da garoa?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "RIO DE JANEIRO" },
                    new Alternativa { Correta = false, Descricao = "PORTO ALEGRE" },
                    new Alternativa { Correta = false, Descricao = "PIRACICABA" },
                    new Alternativa { Correta = true, Descricao =  "SÃO PAULO" }
                }
            },

            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é a área da medicina que trata de crianças?",
                Alternativas= new()
                {
                    new Alternativa { Correta = true, Descricao = "PEDIATRIA" },
                    new Alternativa { Correta = false, Descricao = "GERIATRIA" },
                    new Alternativa { Correta = false, Descricao = "BIOLOGIA" },
                    new Alternativa { Correta = false, Descricao = "INFANTOLOGIA" }
                }
            },
             
            new Pergunta
            {
                Id = 12,
                Enunciado = "Em que país surgiu a máfia?",
                Alternativas= new()
                {
                    new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS" },
                    new Alternativa { Correta = false, Descricao = "INGLATERRA" },
                    new Alternativa { Correta = false, Descricao = "MÉXICO" },
                    new Alternativa { Correta = true, Descricao = "ITÁLIA"}
                }
            },

            new Pergunta
            {
                Id=13,
                Enunciado = "Qual desses é considerado o mês das noivas?",
                Alternativas= new()
                {
                    new Alternativa { Correta = false, Descricao = "JUNHO" }, 
                    new Alternativa { Correta = true, Descricao = "MAIO" },
                    new Alternativa { Correta = false, Descricao = "SETEMBRO" },
                    new Alternativa { Correta = false, Descricao = "OUTUBRO" }        
                }, 
            new Pergunta
            {
                Id=14,
                Enunciado = "Quem inventou o telefone?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = true, Descricao = "GRAHAM BELL" },
                    new Alternativa{ Correta = false, Descricao = "THOMAS EDISON" },
                    new Alternativa{ Correta = false, Descricao = "MARCONI" },
                    new Alternativa{ Correta = false, Descricao = "GEORGE WASHINGTON" }
                }
            }, 
            new Pergunta
            {
                Id =15,
                Enunciado = "Qual é a cor da pedra rubi?",
                Alternativas= new()
                {
                    new Alternativa { Correta = false, Descricao = "AZUL"},
                    new Alternativa { Correta = false, Descricao = "VERDE" },
                    new Alternativa { Correta = false, Descricao = "AMARELA" },
                    new Alternativa { Correta = true, Descricao = "VERMELHA" }
                }  
            }
        };

        List<Pergunta>perguntas_medias = new ()
        { 
            new Pergunta
            {
                Id = 1, 
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                new Alternativa { Correta = false, Descricao = "TRAJANO" },
                new Alternativa { Correta = true, Descricao = "NERO" },
                new Alternativa { Correta = false, Descricao = "BRUTUS" }, 
                new Alternativa { Correta = false, Descricao = "CALÍGULA"
                }
            }, 
            new Pergunta
            {
                Id = 2,
                Enunciado = "Como é chamado quem nasce em Milão, na Itália?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MILANESE" },
                    new Alternativa { Correta = false, Descricao = "MILANOSO" },
                    new Alternativa { Correta = false, Descricao = "MILISTA" },
                    new Alternativa { Correta = false, Descricao = "MILANÊS"}
                }
            },

            new Pergunta
            {
                Id = 3,
                Enunciado = "Em qual estádio Pelé marcou seu milésimo gol?",
                Alternativas = new() 
                {
                    new Alternativa {Correta =  false, Descricao = "MORUMBI" },
                    new Alternativa {Correta = false, Descricao = "PACAEMBU" },
                    new Alternativa {Correta = false, Descricao = "MINEIRÃO" },
                    new Alternativa {Correta = true, Descricao = "MARACANÃ" }
                }
            },

            new Pergunta
            {
                Id = 4,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "CAMICASES"},
                    new Alternativa {Correta = false, Descricao = "SASHIMIS" },
                    new Alternativa {Correta = false, Descricao = "HARAQUIRIS" },
                    new Alternativa {Correta = false, Descricao = "SUMÔS" }
                },

            new Pergunta
            {
                Id = 5,
                Enunciado = "O que é gôndola?",
                Alternativas= new()
                {
                    new Alternativa { Correta = true, Descricao = "EMBARCAÇÃO" },
                    new Alternativa { Correta = false, Descricao = "BRINQUEDO" },
                    new Alternativa { Correta = false, Descricao = "MÚSICA" },
                    new Alternativa { Correta = false, Descricao = "SÍMBOLO" }
                }
            },


            new Pergunta
                { Id = 6,
                  Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?" },
                  Alternativas = new ()
                  {
                      new Alternativa { Correta = false, Descricao = "SENA"},
                      new Alternativa { Correta = true, Descricao = "TÂMISA" },
                      new Alternativa { Correta = false, Descricao = "AUBE" },
                      new Alternativa { Correta = false, Descricao = "RENO" }
                  }
            },

            new Pergunta
            { Id =7,
                 Enunciado = "Qual cantor ficou conhecido como “O rei da voz”?",
                 Alternativas = new()
                 {
                     new Alternativa { Correta = false, Descricao = "ORLANDO SILVA"},
                     new Alternativa { Correta = false, Descricao = "VICENTE CELESTINO"},
                     new Alternativa { Correta = true, Descricao = "FRANCISCO ALVES" },
                     new Alternativa { Correta = false, Descricao = "CARLOS GALHARDO" }
                 }
            },

        }


        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
