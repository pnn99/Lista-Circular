/*  Aluno: Pàulo Nogueira do Nascimento
    Curso: Jogos Digitais 3º Periodo
    Matéria: AEDs
    Professor: Roque Saldanha
*/
using System;

namespace ListaCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();


            list.Insert(new Celula(new Record("Painkiller", "Judas Priest", 06.05f)));
            list.Insert(new Celula(new Record("Holy Wars...The Punishment Due","Megadeth", 06.32f)));
            list.Insert(new Celula(new Record("N.I.B", "Black Sabbath", 06.04f)));
            list.Insert(new Celula(new Record("Fallen Torches", "Mastodon", 04.23f)));
            list.Insert(new Celula(new Record("Man in the Box", "Alice in Chain", 4.44f)));
            list.Insert(new Celula(new Record("Top of the Pops", "The Kinks", 3.41f)));
            list.Insert(new Celula(new Record("Lust for Life", "Iggy Pop", 5.13f)));

            list.Print();
            list.Vazia();
            Console.ReadKey();
            Console.Clear();
            list.PrintReverso();
            Console.ReadKey();

            Console.Clear();
            list.Busca("N.I.B");
            Console.ReadKey();
            list.BuscaCircular("Painkiller");
            Console.ReadKey();

            list.Remove("N.I.B");
            Console.Clear();
            list.Print();
            Console.ReadKey();

            Console.Clear();
            list.Limpar();
            list.Vazia();
        }
    }
}

