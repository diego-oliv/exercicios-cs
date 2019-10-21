using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha
    {
        public bool DescartarMetal()
            {
                System.Console.WriteLine("Esse item irá para a lixeira amarela.");
                return true;
            }
    }
}