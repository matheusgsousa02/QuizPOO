//Pacotes importados para o projeto
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace
namespace QuizPOO.Models
{
    //Class Quiz herdando a lista de Questões
    /// <summary>
    /// Classe Quiz
    /// </summary>
    public class Quiz : List<Question>
    {
        //Sobrecarga de métodos
        /// <summary>
        /// Método de criação do Quiz
        /// </summary>
        public Quiz()
        {
            CreationDate = DateTime.Now;
            Pontuation = 0;
        }

        /// <summary>
        /// Método de criação do Quiz
        /// </summary>
        /// <param name="name"></param>
        public Quiz(string name)
        {
            Name = name;
            CreationDate = DateTime.Now;
            Pontuation = 0;
        }

        /// <summary>
        /// Método de criação do Quiz
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quests"></param>
        public Quiz(string name, List<Question> quests)
        {
            Name = name;
            this.Question = quests;
            CreationDate = DateTime.Now;
            Pontuation = 0;
        }

        /// <summary>
        /// Método responsável por somar a pontuação que é privada
        /// </summary>
        /// <param name="p"></param>
        public void PontuationAdd(int p)
        {
            this.Pontuation += p;
        }

        /// <summary>
        /// Método responsável por mostrar a pontuação total do quiz
        /// </summary>
        /// <returns></returns>
        public int? ShowScore()
        {
            return Pontuation;
        }

        /// <summary>
        /// Getter e Setters
        /// </summary>
        public string? Name { get; set; }
        public List<Question>? Question { get; set; }
        public DateTime? CreationDate { get; set; }
        private int? Pontuation { get; set; }
    }
}
