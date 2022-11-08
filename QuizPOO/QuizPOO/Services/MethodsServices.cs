//Importados
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//Referência
using QuizPOO.Models;
using QuizPOO.Services.Interfaces;

//Namespace separador
namespace QuizPOO.Services
{
    /// <summary>
    /// Classe MethodsServices com implementação de uma interface
    /// </summary>
    public class MethodsServices : IMethodsServices
    {
        /// <summary>
        /// Método com referencia com a interface e program
        /// </summary>
        /// <param name="pont"></param>
        public void SetWinxs(int? pont)
        {
            //(If Else) básico para definir um resultado
            if (pont > 0 && pont <= 45)
            {
                Console.WriteLine("Bloom é uma personagem do Clube das Winx. Ela é protagonista da série e é a líder informal das Winx, assim como a princesa de Domino e a detentora da Chama do Dragão.");
            }
            else if (pont > 45 && pont <= 65)
            {
                Console.WriteLine("Bloom é uma personagem do Clube das Winx. Ela é protagonista da série e é a líder informal das Winx, assim como a princesa de Domino e a detentora da Chama do Dragão.");
            }
            else if (pont > 65 && pont <= 80)
            {
                Console.WriteLine("Flora é uma personagem do Clube das Winx. Ela é a Fada da Natureza, e é uma das melhores amigas de Bloom. Flora é uma garota doce e gentil; e tem vários amigos por isso");
            }
            else if (pont > 80)
            {
                Console.WriteLine("Stella é princesa e fada guardiã de Solaria, também é guardiã do Anel de Solaria e fada do Sol e da Lua.");
            }

        }

        /// <summary>
        /// Método com referencia com a interface e program
        /// </summary>
        /// <param name="quiz"></param>
        /// <returns></returns>
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

            var selectedQuiz = quiz.FirstOrDefault(q => q.Name == quiz[resp - 1].Name).Name;

            return selectedQuiz;
        }

        /// <summary>
        /// Método responsável por Exibir o Quiz
        /// </summary>
        /// <param name="quizz"></param>
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

                int pont = Convert.ToInt32(item.Power.GetValueOrDefault(opt.ToUpper()));

                quizz.PontuationAdd(pont);

                i++;
            }
        }
    }
}
