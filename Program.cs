using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Nokia:");
Nokia n = new Nokia("1-1", "Nokia", "N2", 128, 2);
n.Ligar();
n.ReceberLigacao();
string nomeApp = "GitHub";
n.InstalarAplicativo(nomeApp);

System.Console.WriteLine();

System.Console.WriteLine("iPhone:");
Iphone i = new Iphone("2-2", "iPhone", "i2", 128, 5);
i.Senha = "12";
i.SenhaInstalacao = "12";
i.Ligar();
i.ReceberLigacao();
string nomeAppIphone = "GitHubPro";
i.InstalarAplicativo(nomeAppIphone);