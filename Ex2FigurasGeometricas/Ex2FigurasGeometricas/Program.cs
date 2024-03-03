/*Crie uma hierarquia de formas geométricas onde cada forma (por exemplo, círculo, retângulo) possui um
método para calcular a área. Implemente exceções personalizadas para lidar com casos específicos, como
tentar calcular a área de uma forma não suportada.*/

using Ex2FigurasGeometricas.Entities.Classes.Exceptions;
using Ex2FigurasGeometricas.Entities.Classes.Figuras;
using Ex2FigurasGeometricas.Entities.Enums;
using System.Globalization;

EnumFigura figuraActual;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 2 - Tutorial 12");

    figuraActual = Figura("\nDe qual figura quer saber a área? (Círculo/Triângulo/Quadrado/Rectângulo): ");

    switch (figuraActual)
    {
        case EnumFigura.circulo:
            Circulo();
            break;

        case EnumFigura.triangulo:
            Triangulo();
            break;

        case EnumFigura.quadrado:
            Cuadrado();
            break;

        case EnumFigura.rectangulo:
            Rectangulo();
            break;
    }


} while (DesejaContinuar());

EnumFigura Figura(string enunciado)
{
    string texto;

    while (true)
    {
        try
        {
            texto = String(enunciado).ToLower();

            if (texto == "triângulo")
                return EnumFigura.triangulo;

            if (texto == "rectângulo")
                return EnumFigura.rectangulo;

            if (texto == "círculo")
                return EnumFigura.circulo;

            if (!Enum.TryParse(texto, true, out EnumFigura figura))
                throw new InvalidCastException("Essa figura não é válida!");

            if (!Enum.IsDefined(typeof(EnumFigura), figura))
                throw new FiguraInvalidaException("Aquela figura não é válida");

            return figura;
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine("\nFormato inválido: " + ex.Message);
        }
        catch (FiguraInvalidaException ex)
        {
            Console.WriteLine("\nFigura inválido: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nErro inesperado: " + ex.Message);
        }
    }
}

string String(string enunciado)
{
    string? texto;

    while (true)
    {
        try
        {
            Console.Write(enunciado);
            texto = Console.ReadLine();

            if (string.IsNullOrEmpty(texto))
                throw new ArgumentNullException("O texto inserido está vazio");

            return texto.Trim();

        } 
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("\nArgumento vazio: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nErro inesperado: " + ex.Message);
        }
    }
}

void Circulo()
{
    double radio = Double("\nQual é o radio do círculo?: ");

    Circulo circulo = new(radio);
    Console.WriteLine(circulo);
}

void Triangulo()
{
    double @base = Double("\nQual é o tamanho da base do triângulo?: ");
    double altura = Double("\nQual é a altura do triângulo?: ");

    Triangulo triangulo = new(@base, altura);
    Console.WriteLine(triangulo);
}

void Cuadrado()
{
    double lado = Double("\nQual é o tamanho do lado do quadrado?: ");

    Cuadrado cuadrado = new(lado);
    Console.WriteLine(cuadrado);
}

void Rectangulo()
{
    double largura = Double("\nQual é a largura do rectângulo?: ");
    double comprimento = Double("\nQual é o comprimento do rectângulo?: ");

    Rectangulo rectangulo = new(largura, comprimento);
    Console.WriteLine(rectangulo);
}

double Double(string enunciado)
{
    while (true)
    {
        try
        {
            Console.Write(enunciado);
            if (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double result))
                throw new InvalidCastException("O valor fornecido não é um número valido ._.");

            if (result < 0)
                throw new NumeroInvalidoException("O comprimento nunca pode ser negativo!");

            if (result == 0)
                throw new NumeroInvalidoException("Um comprimento nunca pode ser zero!");

            return result;
        } 
        catch(InvalidCastException ex)
        {
            Console.WriteLine("\nFormato inválido: " + ex.Message);
        }
        catch(NumeroInvalidoException ex)
        {
            Console.WriteLine("\nNúmero inválido: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nErro inesperado: " + ex.Message);
        }
    }
}

bool DesejaContinuar()
{
    string? texto;

    while (true)
    {
        Console.Write("\nDeseja tirar a área doutra figura geometrica? Sim/Não?: ");
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
