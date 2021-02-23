using System;
using System.Globalization;

namespace ListaCircular
{
    public class Record
    {
        public string Nome;
        public string Banda;
        public float Tempo;

        public Record(string nome, string banda, float tempo)
        {
            Nome = nome;
            Banda = banda;
            Tempo = tempo;
        }

        public void Print()
        {
            Console.WriteLine($"{Nome} - {Banda} - {Tempo.ToString("F2", CultureInfo.InvariantCulture)} minutos");
        }
    }
}