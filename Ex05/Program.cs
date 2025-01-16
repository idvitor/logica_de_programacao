// Calcular que recebe 2 numeros e apresenta + - * /

Console.Write("informe o numero 1 numero:");
Double num1 = double.Parse(Console.ReadLine());

Console.Write("informe o numero 2 numero:");
double num2 = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("Soma : " + (num1 + num2));
Console.WriteLine("Subtração : " + (num1 - num2));
Console.WriteLine("Multiplicação : " + (num1 * num2));
if (num2 !=0)
{
    Console.WriteLine("Divisão : " + (num1 / num2));
}
else
{
    Console.WriteLine(" Divisão por ZERO não permitida");
}

