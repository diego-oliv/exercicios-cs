using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GuardaChuva : Lixos, IMetal, IPlastico, IIndefinido
    {
        public bool DescartarMetal()
        {
            System.Console.WriteLine("Esse item irá para a lixeira amarela");
            return true;
        }
        public bool DescartarPlastico()
        {
            System.Console.WriteLine("Esse item irá para a lixeira vermelha.");
            return true;
        }
        public bool DescartarIndefinido()
        {
            System.Console.WriteLine("Esse item irá para a lixeira cinza.");
            return true;
        }
    }
}