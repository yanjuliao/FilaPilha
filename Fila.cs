using System;

namespace FilaPilha
{
	public class Fila
	{
        No cabeca;
        No cauda;

        private void VerificaFila()
        {
            if (cabeca == null)
            {
                throw new InvalidOperationException("A fila está vazia!");
            }
        }
        public void Add(string elemento)
        {

            if (cabeca == null)
            {
                No no = new No(elemento, null, null);
                cabeca = no;
                cauda = no;
            }
            else
            {
                No no = new No(elemento, cauda, null);
                cauda = no;
            }
        }
        public void Remove()
        {
            VerificaFila();
            No no = cauda;
            while (no.getProximo() != cabeca)
            {
                no = no.getProximo();
            }
            this.cabeca = no;
        }
        public void ImprimirFila()
        {
            VerificaFila();
            No no = cauda;
            No novoNo = cabeca;
            while (no != novoNo)
            {
                while (no.getProximo() != novoNo)
                {
                    no = no.getProximo();
                }
                Console.WriteLine(novoNo.getElemento());
                novoNo = no;
                no = cauda;
            }
            Console.WriteLine(no.getElemento());
        }
    }
}
