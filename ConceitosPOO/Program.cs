// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");
Cliente cliente;
cliente = new Cliente();
cliente.Nome = "Kaike";
cliente.Cpf = "20972890572";
Console.WriteLine($"Nome do cliente: {cliente.Nome}");
Console.WriteLine($"Cpf do cliente: {cliente.Cpf}");
