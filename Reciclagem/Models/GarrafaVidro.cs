using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GarrafaVidro : Lixos, IVidro
    {
        public bool DescartarVidro()
        {
            System.Console.WriteLine("Esse item irá para a lixeira verde.");
            return true;
        }
    }
}