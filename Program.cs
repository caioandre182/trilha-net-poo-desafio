using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("NOKIA");
Nokia n = new Nokia("9999-0000", "Nokia N10", "71827187381", 256);
n.Ligar();
n.InstalarAplicativo("WhatsApp");

Console.WriteLine("---------------------------");
Console.WriteLine("IPHONE");
Iphone p = new Iphone("0000-9999", "Iphone 14", "7849745982374", 512);
p.ReceberLigacao();
p.InstalarAplicativo("Telegram");
