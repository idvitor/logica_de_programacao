// Solicitar 2 números ao usuário e realizar teste lógico

Console.WriteLine("N1");
double N1 = double.Parse(Console.ReadLine());

Console.WriteLine("N2");
double N2 = double.Parse(Console.ReadLine());

Console.WriteLine($"N1 é maior que N2? Resposta: {N1 > N2}");
Console.WriteLine($"N1 é maior ou igual que N2? Resposta: {N1 >= N2}");
Console.WriteLine($"N1 é menor que N2? Resposta: {N1 < N2}");
Console.WriteLine($"N1 é menor ou igual que N2? Resposta: {N1 <= N2}");
Console.WriteLine($"N1 é igual que N2? Resposta: {N1 == N2}");
Console.WriteLine($"N1 é diferente que N2? Resposta: {N1 != N2}");
Console.WriteLine($"N1 ou N2 são maior que zero? Resposta: {(N1 > 0 || N2 > 0)}");
Console.WriteLine($"N1 e N2 são maior que zero? Resposta: {(N1 > 0 && N2 > 0)}");




