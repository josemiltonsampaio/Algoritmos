using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public static class Algoritmo_OrdenacaoPorInsercao
    {
        public static void Executar()
        {
            int[] teste = { 5, 3, 4, 6, 2, 7 };
            //string[] teste = { "ameixa","abobora","ovo","pato","caixa","abelha" };

            teste.Imprime();

            OrdenacaoPorInsercaoInt(teste);

            teste.Imprime();
        }

        

        public static void OrdenacaoPorInsercaoInt(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                //i = última carta da direita a ser ordenada
                //j = guarda essa informação mas vai iterando até chegar na primeira carta (0)
                //    esse armazenamento é necessário pois caso contrário alteraríamos o i
                //    atrapalhando o for
                int j = i;

                //se j > 0 e posição j é menor que posição anterior a j
                //precisa da verificação se é > 0 pois como o loop vai do final
                //ao início, ele vai parar quando chegar ao índice 0
                //caso contrário ele tentaria comparar o índice 0 com o -1 (que não existe)
                while (j > 0 && array[j] < array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }
        }


        public static void OrdenacaoPorInsercao<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                //i = última carta da direita a ser ordenada
                //j = guarda essa informação mas vai iterando até chegar na primeira carta (0)
                //    esse armazenamento é necessário pois caso contrário alteraríamos o i
                //    atrapalhando o for
                int j = i;

                //se j > 0 e posição j é menor que posição anterior a j
                //precisa da verificação se é > 0 pois como o loop vai do final
                //ao início, ele vai parar quando chegar ao índice 0
                //caso contrário ele tentaria comparar o índice 0 com o -1 (que não existe)
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    array.Troca(j, j - 1);
                    j--;
                }
            }
        }



       
    }
}
