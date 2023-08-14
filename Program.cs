// See https://aka.ms/new-console-template for more information

Console.WriteLine("Verificador de números primos iniciado.");
Menu();
int opcao;

void Menu()
{
    Console.WriteLine("\nPor gentileza digite a opção desejada:");
    Console.WriteLine("\n1 - Verificar se número é primo;");
    Console.WriteLine("2 - Verificar quantos numeros até o valor informado são primos;");
    Console.WriteLine("9 - Encerrar programa;");
    Console.Write("Opção: ");

    try
    {
        opcao = int.Parse(Console.ReadLine());
        if (opcao == 1)
        {
            IniciaPrimo();
        }
        else if (opcao == 2)
        {
            InicioAte();
        }
        else if (opcao == 9)
        {
            Console.WriteLine("\nAté mais!!");
        }
        else
        {
            Console.WriteLine("\nVocê não digitou uma opção válida");
            Menu();
        }

    }
    catch
    {
        Console.WriteLine("\nVocê não digitou uma opção válida");
        Menu();
    }
}


void IniciaPrimo()
{
    Console.WriteLine("\nDigite um número inteiro positivo para verificar se ele é primo:");
    int valor;
    try
    {
        valor = int.Parse(Console.ReadLine());
        if (valor < 0)
        {
            Console.WriteLine("Por gentileza, digite um número positivo.");
            IniciaPrimo();
        }
        else if (valor == 1)
        {
            Console.WriteLine($"O número {valor} é primo.");
        }
        {
            Console.WriteLine(Verificar(valor));
            Menu();
        }
    }
    catch
    {
        Console.WriteLine("O valor digitado não é um número ou é muito grande.");
        IniciaPrimo();
    }
}

void InicioAte()
{
    Console.WriteLine("\nDigite um número inteiro positivo para verificar até ele:");
    int valor;
    try
    {
        valor = int.Parse(Console.ReadLine());
        if (valor < 0)
        {
            Console.WriteLine("Por gentileza, digite um número positivo.");
            InicioAte();
        }
        else if (valor == 1)
        {
            Console.WriteLine($"O número 1 não é valido para essa ação.");
        }
        {
            Console.WriteLine(Verificar2(valor));
            Menu();
        }
    }
    catch
    {
        Console.WriteLine("O valor digitado não é um número ou é muito grande.");
        InicioAte();
    }
}


string Verificar(int numero)
{
    string nprimo = $"\nO número {numero} não é primo.";

    if (numero == 2 || numero == 3 || numero == 5 || numero == 7 || numero == 11 || numero == 13 || numero == 17 || numero == 19)
    {
        string sprimo = $"\nO número {numero} é primo.";
        return sprimo;
    }
    else if (numero % 2 == 0)
    {
        return nprimo;
    }
    else if (numero % 3 == 0)
    {
        return nprimo;
    }
    else if (numero % 5 == 0)
    {
        return nprimo;
    }
    else if (numero % 7 == 0)
    {
        return nprimo;
    }
    else if (numero % 11 == 0)
    {
        return nprimo;
    }
    else if (numero % 13 == 0)
    {
        return nprimo;
    }
    else if (numero % 17 == 0)
    {
        return nprimo;
    }
    else if (numero % 19 == 0)
    {
        return nprimo;
    }
    else
    {
        int resto;
        bool resultado = true;
        for (int i = 19; i < numero; i++)
        {
            Math.DivRem(numero, i, out resto);
            if (resto == 0)
            {
                resultado = false;
                i = numero;
            }
        }
        if (resultado == false)
        {
            return nprimo;
        }
        else
        {
            string sprimo = $"\nO número {numero} é primo.";
            return sprimo;
        }
    }

}

string Verificar2(int numero)
{

    int primos = 0;

    for (int i = 2; i <= numero; i++)
    {
        if (i == 2 || i == 3 || i == 5 || i == 7 || i == 11 || i == 13 || i == 17 || i == 19)
        {
            primos++;

        }
        else if (i % 2 == 0)
        {
        }
        else if (i % 3 == 0)
        {

        }
        else if (i % 5 == 0)
        {

        }
        else if (i % 7 == 0)
        {

        }
        else if (i % 11 == 0)
        {

        }
        else if (i % 13 == 0)
        {

        }
        else if (i % 17 == 0)
        {

        }
        else
        {
            int resto;
            bool resultado = true;
            for (int y = 19; y < i; y++)
            {
                Math.DivRem(i, y, out resto);
                if (resto == 0)
                {
                    resultado = false;
                    y = i;
                }
            }
            if (resultado == false)
            {

            }
            else
            {
                primos++;

            }
        }
    }

    string nprimos = $"\nSão {primos} números primos.";
    return nprimos;

}