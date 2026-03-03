// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");
Cliente cliente;
cliente = new Cliente();
cliente.Nome = "Kaike";
cliente.Cpf = "20972890572";
Console.WriteLine($"Nome do cliente: {cliente.Nome}");
Console.WriteLine($"Cpf do cliente: {cliente.Cpf}");
Agencia agencia;
agencia = new Agencia();
agencia.Numero = "1234";
agencia.Nome = "Itau";
agencia.Telefone = "24981338850";
Console.WriteLine($"Numero da agencia: {agencia.Numero}");
Console.WriteLine($"Nome da agencia: {agencia.Nome}");
Console.WriteLine($"Telefone da agencia: {agencia.Telefone}");
