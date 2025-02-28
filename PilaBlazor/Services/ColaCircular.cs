namespace PilaBlazor.Services
{
    public class ColaCircular
    {
        public int max;
        public string[] cola { get; set; }
        public int frente;
        public int final;
        private int contador;

        public ColaCircular(int maxx)
        {
            max = maxx;
            cola = new string[max];
            frente = 0;
            final = 0;
            contador = 0;
        }

        public bool ColaVacia()
        {
            return contador == 0;
        }

        public bool ColaLlena()
        {
            return contador == max;
        }

        public void Insertar(string dato)
        {
            if (ColaLlena())
            {
                Console.WriteLine("La cola está llena.");
                return;
            }

            cola[final] = dato;
            final = (final + 1) % max;
            contador++;
        }

        public void Eliminar()
        {
            if (ColaVacia())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            cola[frente] = null; // Marcar como vacío
            frente = (frente + 1) % max;
            contador--;
        }
    }
}