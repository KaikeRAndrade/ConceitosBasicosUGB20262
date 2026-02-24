// See https://aka.ms/new-console-template for more information
int idade;
bool idadevalida = false;
while(!idadevalida)
{
    Console.WriteLine("Digite a sua idade: ");
    try
    {
        idade = Convert.ToInt32(Console.ReadLine());
        idadevalida = true;
        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade");

        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor informado deve ser em algarismos algébrico. Números");
    }


}
