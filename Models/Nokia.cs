namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria, int tamanhoApp) : base(numero, modelo, imei, memoria, tamanhoApp)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if(TamanhoApp < Memoria)
            {
                 Console.WriteLine($"{nomeApp} instalado!");
            }
            else
            {
                System.Console.WriteLine($"Espaço de memória insuficiente, {nomeApp} não seré instalado.");
            }
        }
    }
}