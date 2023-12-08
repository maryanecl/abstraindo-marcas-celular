namespace DesafioPOO.Models
{
    public class iPhone : Smartphone
    {
        public iPhone(string numero, string modelo)
            : base(numero, "iPhone", modelo)
        {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone {Modelo}");
        }
    }
}
