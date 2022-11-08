//Referências e importados
using QuizPOO.Models;
using QuizPOO.Services;
using QuizPOO.Services.Interfaces;
using System.ComponentModel;
using System.Reflection;

//Classe program
class Program
{
    //Método estático main - principal
    static void Main(string[] args)
    {
        //Instanciando uma lista de objetos Quiz - Podendo ter vários Quiz
        var quiz = new List<Quiz>();

        //Iniciando um quiz Winxs
        var questionWinxs = new Quiz("Quem é você em club das Winx?");

        //Criando as questões do quiz, usando dicionario para perguntas e valores relacionados ao valor de cada resposta
        #region .: Question Quiz :.
        questionWinxs.Question = new List<Question>();

        questionWinxs.Question.Add(new Question()
        {
            Id = 1,
            Pergunta = "Você se considera uma pessoa?",
            Option = new Dictionary<string, string>()
                {
                    { "A", "Carismática e Impulsiva" },
                    { "B", "Orgulhosa e Autocentrada" },
                    { "C", "Gentil e Carinhosa" },
                    { "D", "Pessimista e Independente" },
                    { "E", "Otimista e Teimosa" },
                },
            Power = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 5 },
                    { "C", 10 },
                    { "D", 15 },
                    { "E", 20 },
                }
        });

        questionWinxs.Question.Add(new Question()
        {
            Id = 2,
            Pergunta = "Você prefere cores?",
            Option = new Dictionary<string, string>()
                {
                    { "A", "Quentes" },
                    { "B", "Frias" },
                    { "C", "Neutras" },
                },
            Power = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 5 },
                    { "C", 10 },
                }
        });

        questionWinxs.Question.Add(new Question()
        {
            Id = 3,
            Pergunta = "Você Gosta mais de?",
            Option = new Dictionary<string, string>()
                {
                    { "A", "Ficar em casa" },
                    { "B", "Sair" },
                },
            Power = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 5 },
                }
        });

        questionWinxs.Question.Add(new Question()
        {
            Id = 4,
            Pergunta = "Quem é você no grupo de amigos?",
            Option = new Dictionary<string, string>()
                {
                    { "A", "O responsável do grupo" },
                    { "B", "O sincero do grupo" },
                    { "C", "O quieto" },
                    { "D", "O zueiro" },
                    { "E", "O que só existe" },
                },
            Power = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 5 },
                    { "C", 10 },
                    { "D", 15 },
                    { "E", 20 },
                }
        });

        questionWinxs.Question.Add(new Question()
        {
            Id = 5,
            Pergunta = "Você age mais pela?",
            Option = new Dictionary<string, string>()
                {
                    { "A", "Intuição" },
                    { "B", "Razão" },
                },
            Power = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 5 },
                }

        });
        questionWinxs.Question.Add(new Question()
        {
            Id = 6,
            Pergunta = "Que estilo você se identifica?",
            Option = new Dictionary<string, string>()
                {
                    { "A", "Casual" },
                    { "B", "Geek" },
                    { "C", "Fancy" },
                    { "D", "Simples é tudo" },
                },
            Power = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 5 },
                    { "C", 10 },
                    { "D", 15 },
                }
        });
        questionWinxs.Question.Add(new Question()
        {
            Id = 7,
            Pergunta = "Qual sua estação favorita?",
            Option = new Dictionary<string, string>()
                {
                    { "A", "Verão" },
                    { "B", "Outono" },
                    { "C", "Inverno" },
                    { "D", "Primavera" },
                },
            Power = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 5 },
                    { "C", 10 },
                    { "D", 15 },
                }
        });
        questionWinxs.Question.Add(new Question()
        {
            Id = 8,
            Pergunta = "Qual o seu estilo de musica preferido?",
            Option = new Dictionary<string, string>()
                {
                    { "A", "Pop" },
                    { "B", "Kpop" },
                    { "C", "Indie" },
                    { "D", "Funk" },
                },
            Power = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 5 },
                    { "C", 10 },
                    { "D", 15 },
                }
        });
        #endregion

        //Adicionando o QUIZ a lista
        quiz.Add(questionWinxs);

        //Iniciando os métodos gerais
        var methods = new MethodsServices();

        //Faça até não for verdadeiro
        do
        {
            //Seleciona o quiz
            var selectedQuiz = methods.ShowMenu(quiz);

            //Faz um filtro na lita de Quiz pelo quiz selecionado
            var quizz = quiz.FirstOrDefault(q => q.Name == selectedQuiz);

            //Exibe o quiz
            methods.ShowQuiz(quizz);

            //Calcula e exibe o resultado do quiz
            methods.SetWinxs(quizz.ShowScore());

            //Sai do while e finaliza o código
            break;

        } while (true);
    }
}