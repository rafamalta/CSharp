namespace GenericsParte1
{
    public class ServicoDeImpressao<T>
    {
        private T[] _valores = new T[10];
        private int _contador = 0;

        public void AdicionarValor(T valor)
        {
            if (_contador == 10)
            {
                throw new InvalidOperationException("O Serviço de Impressão está cheio!");
            }
            _valores[_contador] = valor;
            _contador++;
        }

        public T Primeiro()
        {
            if (_contador == 0)
            {
                throw new InvalidOperationException("O Serviço de Impressão está vazio!");
            }
            return _valores[0];
        }

        public void Imprimir()
        {
            Console.Write("[");
            for (int i = 0; i < _contador - 1; i++)
            {
                Console.Write(_valores[i] + ", ");
            }
            if (_contador > 0)
            {
                Console.Write(_valores[_contador - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
