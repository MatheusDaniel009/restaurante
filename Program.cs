using System;
using System.ComponentModel;
using System.IO;
using System.Numerics;

Console.WriteLine("restaurante");
Console.ReadKey();
Console.Clear();

double valor = 0;
int quantidade;
char continua = 's';


/* entrada*/ while (continua == 's')
{ 
    Console.WriteLine("pratos de entrada:");
    Console.WriteLine("1) Bruschetta de tomate e manjericão R$10,00\t 4) Ceviche R$15,50");
    Console.WriteLine("2) Guacamole e chips de milho R$13,00 \t\t 5) Sopa de legumes R$9,00");
    Console.WriteLine("3) Rolinhos primavera R$7,00 \t\t\t 6) Croquetes de carne R$16,00");
    Console.WriteLine("\t\t\t\b7) nada");
 
    Console.Write("Por favor, escolha uma opção de prato de entrada: ");
    int entrada = int.Parse(Console.ReadLine());

    while (entrada < 1 || entrada > 7)
    {
        Console.WriteLine("Você digitou um número inválido. Por favor, digite um número válido ");
        entrada = int.Parse(Console.ReadLine());

    }

    if (entrada != 7)
    {
        Console.Write("Quantos você deseja? ");
        quantidade = int.Parse(Console.ReadLine());


        switch (entrada)
        {
            case 1:
                valor = valor + 10.00 * quantidade;
                break;
            case 2:
                valor = valor + 13.00 * quantidade;
                break;
            case 3:
                valor = valor + 7.00 * quantidade;
                break;
            case 4:
                valor = valor + 15.50 * quantidade;
                break;
            case 5:
                valor = valor + 9.00 * quantidade;
                break;
            case 6:
                valor = valor + 16.00 * quantidade;
                break;


        }

        Console.Write("Deseja pedir mais algum prato de entrada? \nDigite 's' para sim ou 'n' para não: ");
        continua = char.Parse(Console.ReadLine());

        while (continua != 's' && continua != 'n')
        {
            Console.Write("vc diguitou errado rediguite por favor:");
            continua = char.Parse(Console.ReadLine());
        }
    }
    else
    {
        continua = 'n';
    }
    Console.Clear();
}



/* principal*/do
{
    Console.WriteLine("pratos principais:");
    Console.WriteLine("1) Risoto de cogumelos R$150,00\t\t\t 4) Espaguete à carbonara R$70,50");
    Console.WriteLine("2) Salmão grelhado com legumes R$130,20 \t\t 5) Frango assado com batatas R$67,90");
    Console.WriteLine("3) Bife com molho de vinho tinto R$200,00 \t 6) Ratatouille R$ 84,76");
    Console.WriteLine("\t\t\t\b7) nada");

    Console.Write("Por favor, escolha o seu prato principal: ");
    int principal = int.Parse(Console.ReadLine());

    while (principal < 1 || principal > 7)
    {
        Console.WriteLine("Você digitou um número inválido. Por favor, digite um número válido ");
        principal = int.Parse(Console.ReadLine());

    }

    if (principal != 7)
    {
        Console.Write("Quantos você deseja? ");
        quantidade = int.Parse(Console.ReadLine());

        switch (principal)
        {
            case 1:
                valor = valor + 150.00 * quantidade;
                break;
            case 2:
                valor = valor + 130.20 * quantidade;
                break;
            case 3:
                valor = valor + 200.00 * quantidade;
                break;
            case 4:
                valor = valor + 70.50 * quantidade;
                break;
            case 5:
                valor = valor + 67.90 * quantidade;
                break;
            case 6:
                valor = valor + 84.76 * quantidade;
                break;
        }
        Console.Write("Deseja pedir mais algum prato principal ? \nDigite 's' para sim ou 'n' para não: ");
        continua = char.Parse(Console.ReadLine());

        while (continua != 's' && continua != 'n')
        {
            Console.Write("vc diguitou errado rediguite por favor:");
            continua = char.Parse(Console.ReadLine());
        }
    }
    else
    {
        continua = 'n';
    }
    Console.Clear();
}
while (continua == 's');


/* bebida*/do
{
    Console.WriteLine("bebidas:");
    Console.WriteLine("1) reviserante R$6,50\t\t 4) Vinhos R$30,00");
    Console.WriteLine("2) Cervejas artesanais R$35,50 \t 5) Sucos naturais R$16,00");
    Console.WriteLine("3) Coquetéis R$65,79 \t\t 6) Água aromatizada R$11,40");
    Console.WriteLine("\t\t\t7) nada");

    Console.Write("Por favor, escolha uma opção de bebida: ");
    int bebida = int.Parse(Console.ReadLine());

    while (bebida < 1 || bebida > 7)
    {
        Console.WriteLine("Você digitou um número inválido. Por favor, digite um número válido ");
        bebida = int.Parse(Console.ReadLine());

    }

    if (bebida != 7)
    {
        Console.Write("Quantos você deseja? ");
        quantidade = int.Parse(Console.ReadLine());

        switch (bebida)
        {
            case 1:
                valor = valor + 6.50 * quantidade;
                break;
            case 2:
                valor = valor + 35.50 * quantidade;
                break;
            case 3:
                valor = valor + 65.79 * quantidade;
                break;
            case 4:
                valor = valor + 30.00 * quantidade;
                break;
            case 5:
                valor = valor + 16.00 * quantidade;
                break;
            case 6:
                valor = valor + 11.40 * quantidade;
                break;


        }

        Console.Write("Deseja pedir mais alguma bebida? \nDigite 's' para sim ou 'n' para não: ");
        continua = char.Parse(Console.ReadLine());

        while (continua != 's' && continua != 'n')
        {
            Console.Write("vc diguitou errado rediguite por favor:");
            continua = char.Parse(Console.ReadLine());
        }
    }
    else
    {
        continua = 'n';
    }
    Console.Clear();
}
while (continua == 's');

/*sobremesa*/do
{
    Console.WriteLine("sobremesas:");
    Console.WriteLine("1) Tiramisu R$15,80\t\t 4) Mousse de chocolate R$7,50");
    Console.WriteLine("2) Pudim de leite R$5,00 \t 5) Sorvete artesanal R$9,00");
    Console.WriteLine("3) Cheesecake R$10,50 \t\t 6) Petit Gateau R$8,78");
    Console.WriteLine("\t\t7) nada");

    Console.Write("Por favor, escolha uma opção de sobremesa: ");
    int sobremesa = int.Parse(Console.ReadLine());

    while (sobremesa < 1 || sobremesa > 7)
    {
        Console.WriteLine("Você digitou um número inválido. Por favor, digite um número válido ");
        sobremesa = int.Parse(Console.ReadLine());

    }

    Console.Write("Deseja pedir mais alguma sobremesa? \nDigite 's' para sim ou 'n' para não: ");
    continua = char.Parse(Console.ReadLine());

    while (continua != 's' && continua != 'n')
    {
        Console.Write("vc diguitou errado rediguite por favor:");
        continua = char.Parse(Console.ReadLine());
    }

    if (sobremesa != 7)
    {
        Console.Write("Quantos você deseja? ");
        quantidade = int.Parse(Console.ReadLine());


        switch (sobremesa)
        {
            case 1:
                valor = valor + 15.80 * quantidade;
                break;
            case 2:
                valor = valor + 5.00 * quantidade;
                break;
            case 3:
                valor = valor + 10.50 * quantidade;
                break;
            case 4:
                valor = valor + 7.50 * quantidade;
                break;
            case 5:
                valor = valor + 9.00 * quantidade;
                break;
            case 6:
                valor = valor + 8.78 * quantidade;
                break;


        }

        Console.Clear();
    }
    else
    {
        continua = 'n';
    }
    Console.Clear();
}
while (continua == 's');

Console.WriteLine("O valor total do seu pedido é de R$" + valor+". Agradecemos pela sua compra!");


