using System;

namespace ListaCircular
{
    public class List
    {
        public Celula sentinela;
        public Celula atual;
        public Celula primeiro;
        public Celula ultimo;
        int intCount;

        public List()
        {
            sentinela = new Celula();
            ultimo = sentinela;
            atual = new Celula();
            primeiro = new Celula();
            sentinela.proximo = null;
            sentinela.anterior = null;
            intCount = 0;
        }

        public bool Vazia()
        {
            if(intCount == 0)
            {
                Console.WriteLine("\nLista Vazia");
            }
            else
            {
                Console.WriteLine("\nLista Formada");
            }

            return (intCount == 0);
        }

        public void Insert(Celula celula)
        {
            ultimo.proximo = celula;
            primeiro = sentinela.proximo;
            celula.anterior = ultimo;
            ultimo = celula;
            primeiro.anterior = ultimo;
            atual = celula;
            celula.proximo = primeiro;

            intCount ++;
        }

        public void Remove(string nome)
        {
            bool itemRemovido = false;
            Celula aux = sentinela;

            if(!Vazia())
            {
                while (aux.proximo != null)
                {
                    if(aux.proximo.record.Nome == nome)
                    {
                        aux.proximo = aux.proximo.proximo;
                        aux.proximo.anterior = aux;
                        itemRemovido = true;
                        
                        intCount --;
                        break;
                    }
                    else
                    {
                        aux = aux.proximo;
                    }
                }
                if(itemRemovido == false)
                {
                    Console.WriteLine("Item não encontrado");
                }
            }
        }

        public void Busca(string n)
        {
            if(!Vazia())
            {
                Celula aux = sentinela;
                bool itemEncontrado = false;

                for (int i = 0; i < intCount; i++)
                {
                    if(aux.proximo.record.Nome == n)
                    {
                        Console.WriteLine();
                        aux.proximo.Print();
                        Console.WriteLine("Musica encontrada!");
                        Console.WriteLine($"Ela está na {i + 1}º posição");

                        itemEncontrado = true;
                    }
                    aux = aux.proximo;
                }
                if (itemEncontrado == false)
                {
                    Console.WriteLine("Input Inválido");
                }
            }
        }

        public void BuscaCircular(string nome)
        {
            Celula aux = ultimo;
            bool itemEncontrado = false;

            for (int i = 0; i < intCount; i++)
                {
                    if(aux.proximo.record.Nome == nome)
                    {
                        Console.WriteLine();
                        aux.proximo.Print();
                        Console.WriteLine("Musica encontrada!");
                        Console.WriteLine($"Ela está na {i + 1}º posição");

                        itemEncontrado = true;
                    }
                    aux = aux.anterior;
                }
                if (itemEncontrado == false)
                {
                    Console.WriteLine("Input Inválido");
                }
        }

        public void Print()
        {
            Celula aux = sentinela;

            for (int i = 0; i < intCount; i++)
            {
                aux.proximo.Print();
                aux = aux.proximo;
            }
        }

        public void PrintReverso()
        {
            Celula aux = sentinela;

            for (int i = intCount; i <= 0 ; i--)
            {
                aux.proximo.Print();
                aux = aux.proximo;
            }
        }

        public void Limpar()
        {
            sentinela.proximo = null;
            sentinela.anterior = null;
            ultimo = sentinela;
            intCount = 0;

            Console.WriteLine("Lista apagada com sucesso");
        }
    }
}