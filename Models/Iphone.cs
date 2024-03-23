namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public string Senha { get; set; }
        public string SenhaInstalacao { get; set; }
        public Iphone(string numero, string modelo, string imei, int memoria, int tamanhoApp) : base(numero, modelo, imei, memoria, tamanhoApp)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        { 
            if(TamanhoApp < Memoria && Senha == SenhaInstalacao)
            {
                 Console.WriteLine($"{nomeApp} instalado!");
            }
            else if(TamanhoApp > Memoria)
            {
                Console.WriteLine($"Espaço de memória insuficiente, {nomeApp} não seré instalado.");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
        }
    }
}