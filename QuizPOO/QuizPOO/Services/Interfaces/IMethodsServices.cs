//Namespace
namespace QuizPOO.Services.Interfaces
{
    /// <summary>
    /// Interface dos métodos gerais
    /// </summary>
    public interface IMethodsServices
    {
        /// <summary>
        /// Método Abstrato responsável por calcular e exibir o resultado do quiz
        /// </summary>
        /// <param name="pont"></param>
        void SetWinxs(int? pont);

        /// <summary>
        /// Método Abstrato responsável por exibir o menu
        /// </summary>
        /// <param name="quiz"></param>
        /// <returns></returns>
        string ShowMenu(List<Models.Quiz> quiz);
    }
}