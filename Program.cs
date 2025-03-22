String textoDigitado;
String fraseDigitada;
Console.Write("Digite uma frase para o Cebolinha:");
textoDigitado = Console.ReadLine();
textoDigitado = textoDigitado.Replace("R", "L").Replace("r", "l");
Console.WriteLine($"{textoDigitado}!");
