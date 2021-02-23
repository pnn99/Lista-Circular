namespace ListaCircular
{
    public class Celula
    {
        public Record record;
        public Celula proximo;
        public Celula anterior;

        public Celula(Record r)
        {
            record = r;
        }

        public Celula()
        {
            record = null;
            proximo = null;
            anterior = null;
        }

        public void Print()
        {
            record.Print();
        }
    }
}