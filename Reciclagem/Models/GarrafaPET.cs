using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GarrafaPET : Lixos, IPlastico
    {
        public bool DescartarPlastico()
        {
            System.Console.WriteLine("Esse item irá para a lixeira vermelha.");
            return true;
        }
    }
}