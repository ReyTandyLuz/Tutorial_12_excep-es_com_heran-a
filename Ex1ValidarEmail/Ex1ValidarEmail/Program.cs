/*Crie uma classe EmailInvalidoException que herde de Exception. Em seguida, crie uma classe Utilizador
com um método DefinirEmail que aceita o e-mail como argumento. Se o e-mail fornecido não contiver o
caractere '@', lance a exceção EmailInvalidoException.*/

using Ex1ValidarEmail.Entities;

string email;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 1 - Tutorial 12 Excepções com herança");

    try
    {
        email = String("\nInsira um email: ");

        Console.WriteLine("\nO e-mail é valido :D");
    }
    catch (EmailInvalidoException ex)
    {
        Console.WriteLine($"\nE-mail invalido: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro inesperado: {ex.Message}");
    }

} while (DesejaContinuar());

string String(string enunciado)
{
    string? texto;

    while (true)
    {
        Console.Write(enunciado);
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            Utilizador.DefinirEmail(texto);
            return texto.Trim();
        }

        Console.WriteLine("\n\tValor invalido!!!!!! Tente novamente");
    }
}

bool DesejaContinuar()
{
    string? texto;

    while (true)
    {
        Console.Write("\nDeseja tentar inserir outro e-mail? Sim/Não?: ");
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            if (texto.ToLower() == "sim")
                return true;

            if (texto.ToLower() == "não" || texto.ToLower() == "nao")
                return false;
        }

        Console.WriteLine("\nOpção inválida!!!!! É SIM/NÃO!!!");
    }
}
