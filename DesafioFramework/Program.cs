using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFramework
{
    class Program
    {        
        static void Main(string[] args)
        {
             /* 1. Dado uma lista de valores inteiros e um valor k,
              * retorne true se a soma de dois valores da lista for igual a k.
              * Exemplo, dada lista[10, 15, 3, 7] e k = 17 então a saída será true porque 10 + 7 = 17.*/

            /* int[] lista = new int[4] { 10, 15, 3, 7 };
             int k = 17;
             string retorno = "";

             for (int i = 0; i < lista.Length; i++)
             {
                 for (int j = i + 1; j < lista.Length; j++)
                 {
                     if (k == lista[i] + lista[j])
                     {
                         retorno = retorno + "TRUE ==> " + lista[i].ToString() + " + " + lista[j].ToString() + " = " + 
                                   k.ToString() + "\n";
                     }
                 }
             }
             Console.WriteLine(retorno);
             Console.Read();*/

            /* 2. Dado um array de inteiros, devolva um novo array onde cada elemento na posição i 
             * do novo array é o produto de todos os valores do array original exceto o elemento na posição i.
             * Por exemplo, se forem informados os valores [1,2,3,4,5], o resultado esperado deve ser igual
             * a [120,60,40,30,24]. Se informamos os valores [3,2,1], e espera-se como resposta os valores
             * [2,3,6]. */

            /*int[] original = new int[5] { 1, 2, 3, 4, 5 };
            int[] produto = new int[5];
            int multiplicacao;

            //Primeiro for varre cada elemento do arrey.
            for (int i = 0; i < original.Length; i++)  
            {
                multiplicacao = 1;

            //Segundo for é responsavel pela multiplicação dos elementos exeto o da posição m.
                for (int m = 0; m < original.Length; m++)
                {
                    if (i == m)
                    {
                        continue;                       
                    }
                    else
                    {
                        multiplicacao = multiplicacao * original[m];
                    }
                }

                produto[i] = multiplicacao;
            }

            Console.WriteLine(string.Join(", ", produto));
            Console.Read();*/


            /* 3. Considere uma escadaria com n degraus e você pode subir 1 ou 2 degraus por vez. 
             * Dado n, retorne o número de maneiras únicas de subir a escada. Por exemplo, dado n = 4, 
             * existem 5 maneiras exclusivas: [1,1,1,1], [2,1,1], [1,2,1], [1,1,2], [2,2] */














            /* 4. Power set é um conjunto gerado a partir da combinação de todos os seus subconjuntos.
             * Dado um conjunto V, retorne o power set deste conjunto de entrada. Por exemplo, 
             * dado V = [1,2,3], a saída deve ser igual a [], [1], [2], [3], [1,2], [1,3], [2,3], [1,2,3] */


        }
    }
}
    

