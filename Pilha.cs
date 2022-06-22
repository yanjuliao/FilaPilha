using System;

namespace FilaPilha
{
	public class Pilha
	{
        No cabeca;
        No cauda;

        private void VerificaPilha()
        {
            if (cauda == null)
            {
                throw new InvalidOperationException("A pilha está vazia!");
            }
        }

        public void Add(string elemento)
        {
            cauda = new No(elemento, this.cauda, this.cabeca);
        }

        public void Remove()
        {
            VerificaPilha();
            cauda = cauda.getProximo();
        }
        public void ImprimirPilha()
        {
            VerificaPilha();
            No no = cauda;
            while (no.getProximo() != null)
            {
                Console.WriteLine(no.getElemento());
                no = no.getProximo();
            }
            Console.WriteLine(no.getElemento());
        }
    }
}
