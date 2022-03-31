using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class Algoritmo_OrdenacaoPorSelecao
    {
        public static void Executar()
        {
            int[] teste = { 5, 3, 4, 6, 2, 7 };
            //string[] teste = { "ameixa","abobora","ovo","pato","caixa","abelha" };
            
            teste.Imprime();

            teste = OrdenacaoPorSelecao(teste);

            teste.Imprime();

            int indiceMenorValor = teste.MenorIndice();

            Console.WriteLine($"O menor valor é {teste[indiceMenorValor]} e está no índice {indiceMenorValor}");

        }

        public static int[] OrdenacaoPorSelecao(int[] array)
        {
            var novoArray = new int[array.Length];

            //verifico o tamanho do novoArray porque o array vai perder elementos durante a execução
            for(int i = 0; i < novoArray.Length; i++)
            {
                int menor = array.MenorIndice();
                novoArray[i] = array[menor];
                array = array.Remove(menor);
            }
            return novoArray;
        }
    }
}
