using DesafioPOO.Models;

// Implementado!!!
Console.WriteLine("Tijolão da Nokia:");
Nokia cel1 = new Nokia("031999999999", "Nokia 6110", "1111111111", 50);
cel1.Ligar("031988888888");
cel1.InstalarAplicativo("Snake");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Iphone cel2 = new Iphone("031988888888", "iPhone 3GS", "3333333333", 32000000);
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Fruit Ninja");