using Knapsack;

Console.WriteLine("Enter the number of items:");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter the seed:");
int seed = int.Parse(Console.ReadLine() ?? "0");

Problem problem = new Problem(n, seed);//zrobienie nowego problemu z seedem i iloscia przedmiotow
Console.WriteLine("\nGenerated Instance:");
Console.WriteLine(problem.ToString());//wypisanie wszystkich przedmiotów, ich id, wartości i wagi

Console.WriteLine("\nEnter the capacity:");
int capacity = int.Parse(Console.ReadLine() ?? "0");

var result = problem.Solve(capacity);//rozwiazanie calego problemu
Console.WriteLine("\nResult:");
Console.WriteLine(result.ToString());