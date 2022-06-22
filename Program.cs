using System;

namespace FilaPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            //Primeiro a entrar é o primeiro a sair
            fila.Add("Yan");
            fila.Add("Unker");
            fila.Add("Joãozin doidão");
            fila.ImprimirFila();

            Console.WriteLine("-----------Após o Remove só sobrou Joãozin doidão---------------");

            fila.Remove();
            fila.Remove();
            fila.ImprimirFila();

            Pilha pilha = new Pilha();

            Console.WriteLine("-----------------------Pilha--------------------");

            // Ultimo a entrar é o primeiro a sair
            pilha.Add("Joãozin doidão");
            pilha.Add("Unker");
            pilha.Add("Yan");
            pilha.Remove();
            pilha.ImprimirPilha();
        }
    }
}
