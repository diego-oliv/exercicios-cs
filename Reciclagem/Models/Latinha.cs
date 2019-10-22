using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : Lixos, IMetal
    {
        public bool DescartarMetal()
            {
                System.Console.WriteLine("Esse item irá para a lixeira amarela.");
                return true;
            }
    }
}