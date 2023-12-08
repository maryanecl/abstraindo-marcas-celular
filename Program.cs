using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            Nokia nokia = new Nokia("123456", "Lumia");
            
            iPhone iPhoneInstance = new iPhone("789012", "12");

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine(); 

            iPhoneInstance.Ligar();
            iPhoneInstance.ReceberLigacao();
            iPhoneInstance.InstalarAplicativo("Instagram");
        }
    }
}
