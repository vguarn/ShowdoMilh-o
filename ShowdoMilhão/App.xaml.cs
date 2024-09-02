using Android.OS;
using Microsoft.CSharp.RuntimeBinder;
using ShowdoMilhão.Models;

namespace ShowdoMilhão
{
    public partial class App : Application
    {
        static List<Pergunta> perguntas_faceis = new()
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
                }
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
                }
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
                }
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
                }
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

        static List<Pergunta> perguntas_medias = new()
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
                    new Alternativa { Correta = false, Descricao = "CALÍGULA" }
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
                }
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
                  Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?",
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

            new Pergunta
            {
                Id =8,
                Enunciado = "Qual é a letra do alfabeto que simboliza o número dez em algarismo romano?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "V"},
                    new Alternativa { Correta=false, Descricao="D"},
                    new Alternativa { Correta = false, Descricao= "L" },
                    new Alternativa { Correta = true, Descricao = "X" }
                }

            },

            new Pergunta
            {
                Id =9,
                Enunciado = "A que categoria pertence o cavalo-marinho?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao ="MULUSCOS" },
                    new Alternativa { Correta = true, Descricao = "PEIXE" },
                    new Alternativa { Correta = false, Descricao = "CRUSTÁCEO" },
                    new Alternativa { Correta = false, Descricao = "MAMÍFERO" }
                }
            },

            new Pergunta
            {
                Id =10,
                Enunciado = "Em que cidade foram realizados os jogos olímpicos de 2000?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LONDRES"},
                    new Alternativa { Correta = false, Descricao = "ATLANTA" },
                    new Alternativa { Correta = false, Descricao = "BEIJING" },
                    new Alternativa { Correta = true, Descricao = "SYDNEY"}
                }
            },

            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual foi o último imperador do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "D. PEDRO II"},
                    new Alternativa { Correta = false, Descricao = "D. PEDRO I" },
                    new Alternativa { Correta = false, Descricao = "D. JOÃO VI" },
                    new Alternativa { Correta = false, Descricao = "DEODORO DA FONSECA" }
                }
            },

            new Pergunta
            {
                Id=12,
                Enunciado = "Por que nome são conhecidas as pessoas do Pólo Ártico?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "SULISTAS"},
                    new Alternativa {Correta = true, Descricao = "ESQUIMÓS" },
                    new Alternativa {Correta = false, Descricao = "NORTISTAS" },
                    new Alternativa {Correta = false, Descricao = "POLARES"}
                }
            },

            new Pergunta
            {
                Id=13,
                Enunciado = "Qual é a capital do Estado de Mato Grosso do Sul?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUIABÁ" },
                    new Alternativa {Correta = false, Descricao = "VÁRZEA GRANDE" },
                    new Alternativa { Correta = false, Descricao = "RONDONÓPOLIS" },
                    new Alternativa {Correta = true, Descricao = "CAMPO GRANDE" }
                }
            },

            new Pergunta
            {
                Id=14,
                Enunciado = "Teresina é a capital de qual estado brasileiro?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "TOCANTINS"},
                    new Alternativa {Correta = true, Descricao = "PIAUÍ" },
                    new Alternativa {Correta = false, Descricao = "ACRE" },
                    new Alternativa {Correta = false, Descricao = "PARANÁ"}
                }
            },

            new Pergunta
            {
                Id= 15,
                Enunciado = "Em que ano ocorreu o incêndio do edifício Joelma, na cidade de São Paulo?",
                Alternativas= new()
                {
                    new Alternativa {Correta = false, Descricao = "1971" },
                    new Alternativa {Correta = false, Descricao = "1972" },
                    new Alternativa {Correta = false, Descricao = "1973" },
                    new Alternativa {Correta = true, Descricao = "1974" }
                }
            },
         };

        static List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "O que são meninges?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "MEMBRANA" },
                    new Alternativa {Correta = false, Descricao = "CÉLULAS"},
                    new Alternativa {Correta = false, Descricao = "MÚSCULOS" },
                    new Alternativa {Correta = false, Descricao = "NERVOS" }
                }
            },

            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual presidente brasileiro instituiu o AI-5?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "COSTA E SILVA" },
                    new Alternativa {Correta = false, Descricao = "ERNESTO GEISEL" },
                    new Alternativa {Correta = false, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa {Correta = false, Descricao = "ITAMAR FRANCO" }
                }
            },

            new Pergunta
            {
                Id=3,
                Enunciado = "Os nazistas foram julgados em:",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "BERLIM"},
                    new Alternativa {Correta = true, Descricao = "NUREMBERGUE" },
                    new Alternativa {Correta = false, Descricao = "MUNIQUE"},
                    new Alternativa {Correta = false, Descricao = "PARIS"}
                }
            },

            new Pergunta
            {
                Id= 4,
                Enunciado = "Qual oceano tem o maior volume de água?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "PACÍFICO"},
                    new Alternativa {Correta = false, Descricao = "ATLÂNTICO"},
                    new Alternativa {Correta = false, Descricao = "ÍNDICO" },
                    new Alternativa {Correta = false, Descricao = "ÁRTICO" }
                }
            },

            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual o símbolo químico do radônio?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "Rr"},
                    new Alternativa {Correta = false, Descricao = "Rd"},
                    new Alternativa {Correta = true, Descricao = "Rn"},
                    new Alternativa {Correta = false, Descricao = "Ro" }

                }
            },

            new Pergunta
            {
                Id = 6,
                Enunciado = "Como é chamada a bola de gelo e poeira que orbita em torno do sol?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "COMETA"},
                    new Alternativa {Correta = false, Descricao = "METEORITO" },
                    new Alternativa {Correta = false, Descricao = "CAMADA DE OZÔNIO" },
                    new Alternativa {Correta = false, Descricao = "ESTRELA D'ALVA" }
                }
            },

            new Pergunta
            {
                Id=7,
                Enunciado = "Em que ano foi inaugurada a estátua do Cristo Redentor no Rio de Janeiro?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "1921" },
                    new Alternativa {Correta = true, Descricao = "1931" },
                    new Alternativa {Correta = false, Descricao = "1941" },
                    new Alternativa {correta = false, Descricao = "1951" }
                }
            },

            new Pergunta
            {
                Id=8,
                Enunciado = "A que país deve-se viajar para subir o Monte Parnaso?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ITÁLIA"},
                    new Alternativa {Correta = false, Descricao = "FRANÇA" },
                    new Alternativa {Correta = true, Descricao = "GRÉCIA" },
                    new Alternativa {Correta = false, Descricao = "TURQUIA" }
                }
            },

            new Pergunta
            {
                Id =9,
                Enunciado = "O que é talude?",
                Alternativas= new()
                {
                    new Alternativa {Correta = false,Descricao = "AVALANCHE DE NEVE" },
                    new Alternativa {Correta = false, Descricao = "FUNGO" },
                    new Alternativa {Correta = true, Descricao = "INCLINAÇÃO DE TERRENO" },
                    new Alternativa {Correta = false, Descricao = "RITO ISLÂMICO" }
                }

            },

            new Pergunta
            {
                Id = 10,
                Enunciado = "Qual atleta foi desclassificado por uso de doping nas Olimpíadas de 1988?",
                Alternativas= new()
                {
                    new Alternativa{Correta = false, Descricao= "MIKE POWELL" },
                    new Alternativa{Correta = true, Descricao = "BEN JOHNSON" },
                    new Alternativa{Correta = false, Descricao = "CARL LEWIS" },
                    new Alternativa{Correta = false, Descricao= "LINFORD CHRISTIE" }
                }
            }
        };

        static List<Pergunta> perguntas_finais = new()
        {
            new Pergunta
            { Id = 1,
              Enunciado="Qual a obra de arte mais cara já arrematada em um leilão?",
              Alternativas = new()
              {
                  new Alternativa {Correta = false, Descricao="O GRITO, DE EDVARD MUNCH"},
                  new Alternativa{Correta = false, Descricao="INTERCÂMBIO, DE WILLEN DE KOONING" },
                  new Alternativa{Correta =  false, Descricao = "O SONHO, DE PABLO PICASSO" },
                  new Alternativa{Correta = true, Descricao = "SALVATOR MUNDI, DE LEONARDO DA VINCI" }
              }
            },

            new Pergunta 
            { Id = 2,
                Enunciado="Qual a maior operação militar da história, que contou com o deslocamento de 3,8 milhões de soldados?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao= ""}
                }
        }


        static List<Pergunta> perguntas_sorteadas = new();

        public static Pergunta getRandowPerguntaFacil()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 15);
                pergunta_sorteada = perguntas_faceis[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }
            return pergunta_sorteada;
        }

        public static Pergunta getRandowPerguntaMedia()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 15);
                pergunta_sorteada = perguntas_medias[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add (pergunta_sorteada);
                    break;
                }
            }

            return pergunta_sorteada;
        }

        public static Pergunta getRandowPerguntaDificil()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 15);
                pergunta_sorteada = perguntas_dificeis[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }

            return pergunta_sorteada;

        }
        


        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
