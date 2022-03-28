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
    }
}
