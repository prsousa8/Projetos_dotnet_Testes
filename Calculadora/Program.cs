using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();
int num1 = 4;
int num2 = 5;
Console.WriteLine($"{num1} + {num2} = {c.Somar(num1,num2)}");