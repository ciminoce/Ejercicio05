// See https://aka.ms/new-console-template for more information
double radio, perimetro, supercie;
Console.Write("Ingrese el valor del radio de la circunferencia:");
radio=double.Parse(Console.ReadLine());
perimetro = 2 * radio * Math.PI;
supercie = Math.PI * Math.Pow(radio, 2);
Console.WriteLine($"Una circ de radio {radio} tiene un perímetro de {perimetro} y una superficie de {supercie}");
