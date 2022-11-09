// Variáveis iniciando em 0
int num1 = 0; int num2 = 0;

// Digito de primeiro número
Console.WriteLine("Digite algum número e tecle Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Digito de segundo número
Console.WriteLine("Digite outro número e tecle Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Seleção de operação
Console.WriteLine("Escolha uma opção:");
Console.WriteLine("\ta - Adição");
Console.WriteLine("\ts - Subtração");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td - Divisão");
Console.WriteLine("\tr - Resto");

// Switch case para decidir qual lógica de operação
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Resultado: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Resultado: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Resultado: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Resultado: {num1} / {num2} = " + (num1 / num2));
        break;
    case "r":
        Console.WriteLine($"Resultado: {num1} % {num2} = " + num1 % num2);
        break;
}

Console.Write("Pressione qualquer tecla para fechar a calculadora.");
Console.ReadKey();