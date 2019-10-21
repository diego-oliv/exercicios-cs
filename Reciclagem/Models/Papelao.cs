using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Papelao : Lixos, IPapel
    {
        public bool DescartarPapel()
        {
            System.Console.WriteLine("Esse item irá para a lixeira azul.");
            return true;
        }
    }
}