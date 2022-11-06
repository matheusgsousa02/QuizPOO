using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizPOO.Models;
using QuizPOO.Services.Interfaces;

namespace QuizPOO.Services
{
    public class MethodsServices : IMethodsServices
    {
        public int SetWinxs(int p)
        {
            int a = 1;

            return a;
        }

        public string ShowMenu(List<Models.Quiz> quiz)
        {
            Console.WriteLine("Escolha o quiz desejado: ");
            var i = 1;
            var resp = quiz.Count + 1;
            foreach (var item in quiz)
            {
                Console.WriteLine($" {i} - {item.Name}");
                i++;
            }

            resp = Convert.ToInt32(Console.ReadLine());

            var selectedQuiz = quiz.FirstOrDefault(q => q.Name == quiz[resp-1].Name).Name;

            return selectedQuiz;
        }

        public void ShowQuiz(Quiz? quizz)
        {
            var i = 1;
            Console.WriteLine($"{quizz.Name}");

            foreach (var item in quizz.Question)
            {
                Console.WriteLine($"Pergunta {i}:");
                Console.WriteLine(item.Pergunta);
                Console.WriteLine(String.Join("\n\r", item.Option));

                var opt = Console.ReadLine();

                var pont = item.Power.GetValueOrDefault(opt?.ToUpper());

                quizz.PontuationAdd(pont);

                i++;
            }
        }
    }
}
