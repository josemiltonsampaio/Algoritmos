namespace Algoritmos
{
    public static class ExtensoesDeArray
    {
        public static void Imprime<T>(this T[] array)
        {
            Console.WriteLine(string.Join(", ", array.ToList<T>()));
        }

        public static void Troca<T>(this T[] array, int primeiro, int segundo)
        {
            T temp = array[primeiro];
            array[primeiro] = array[segundo];
            array[segundo] = temp;
        }

        public static int MenorIndice(this int[] array)
        {
            int menor = -1;
            int indiceMenor = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    menor = array[i];
                    indiceMenor = i;
                    continue;
                }

                if (array[i] < menor)
                {
                    menor = array[i];
                    indiceMenor = i;
                }

            }

            return indiceMenor;
        }

        public static T[] Remove<T>(this T[] array, int indice)
        {
            var lista = new List<T>(array);
            lista.RemoveAt(indice);
            return lista.ToArray();
        }
    }
}
