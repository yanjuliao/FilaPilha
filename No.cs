using System;

namespace FilaPilha
{

	public class No
	{
        private string elemento;
        private No proximo;
        private No anterior;

        public No(string elemento, No proximo, No anterior)
        {
            this.elemento = elemento;
            this.proximo = proximo;
            this.anterior = anterior;
        }

        public string getElemento()
        {
            return elemento;
        }

        public void setElemento(string elemento)
        {
            this.elemento = elemento;
        }

        public No getProximo()
        {
            return proximo;
        }

        public void setProximo(No proximo)
        {
            this.proximo = proximo;
        }

        public No getAnterior()
        {
            return anterior;
        }

        public void setAnterior(No anterior)
        {
            this.anterior = anterior;
        }
    }
}
