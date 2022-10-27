/* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não */


int numero;
Console.WriteLine("Informe um número");
numero = int.Parse(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("Não Negativo");
}