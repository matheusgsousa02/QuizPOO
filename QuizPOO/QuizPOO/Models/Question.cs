//Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//Namespace para separar
namespace QuizPOO.Models
{
    //Classe Question
    public class Question
    {
        /// <summary>
        /// Construtor da classe Question
        /// </summary>
        public Question()
        {
            Id += 1;
            this.Option = new Dictionary<string, string>();
            this.Power = new Dictionary<string, int>();
        }

        /// <summary>
        /// Getter e Setters
        /// </summary>
        public int Id { get; set; }
        public string? Pergunta { get; set; }
        public int? Answer { get; set; }
        //Dicionario para receber as opções
        public Dictionary<string, string> Option { get; set; }
        //Dicionario para receber o valor de cada opção
        public Dictionary<string, int> Power { get; set; }
    }
}
