using System;
using System.Collections;
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

            int[] lista = new int[4] { 10, 15, 3, 7 };
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
            Console.Read();

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

            /*int degraus = 4;
            int degrauUm = 1;
            int degrauDois = 2;                      
            string primeiraCombinacao = "";
            string ultimaCombinacao = "";
            string demaisCombinacoes = "";
            string[] combinacoes = new string[5];           

            for (int i = 0; i < degraus; i++)
            {
                if (i == 0)
                {
                    //Primeiro elemento da combinação
                    for (int j = 0; j < degraus; j++)
                    {
                        if (j == degraus - 1)
                        {
                            primeiraCombinacao = "[" + primeiraCombinacao + degrauUm + "]";
                        }
                        else
                        {
                            primeiraCombinacao = primeiraCombinacao + degrauUm + ",";
                        }
                    }

                    combinacoes[i] = primeiraCombinacao;
                }                
                else
                {
                    //Os demais elementos da combinação
                    demaisCombinacoes = "";

                    for (int j = 1; j < degraus; j++)
                    {
                        if (j == i)
                        {
                            demaisCombinacoes = demaisCombinacoes + degrauDois.ToString() + ",";
                        }
                        else
                        {
                            demaisCombinacoes = demaisCombinacoes + degrauUm.ToString() + ",";
                        }

                        if (j == degraus - 1)
                        {
                            demaisCombinacoes = "[" + demaisCombinacoes + "]";
                        }                        
                    }

                    combinacoes[i] = demaisCombinacoes;
                }

                if (i == degraus - 1)
                {
                    //Último elemento da combinação
                    for (int j = 2; j < degraus; j++)
                    {
                        if (j == degraus - 1)
                        {
                            ultimaCombinacao = "[" + ultimaCombinacao + degrauDois + "]";
                        }
                        else
                        {
                            ultimaCombinacao = ultimaCombinacao + degrauDois + ",";
                        }
                    }

                    combinacoes[i] = ultimaCombinacao;
                }
            }
            
            Console.WriteLine(string.Join(", ", combinacoes));
            Console.Read();*/

            /* 4. Power set é um conjunto gerado a partir da combinação de todos os seus subconjuntos.
             * Dado um conjunto V, retorne o power set deste conjunto de entrada. Por exemplo, 
             * dado V = [1,2,3], a saída deve ser igual a [], [1], [2], [3], [1,2], [1,3], [2,3], [1,2,3] */

            /*int[] V = new int[3] { 1, 2, 3 };            
            string subConjunto = "[]";
            string ultimoSubConjunto = ", [";

            for (int i = 0; i < V.Length; i++)
            {
                subConjunto = subConjunto + ", [" + V[i] + "]";

                for (int j = i + 1; j < V.Length; j++)
                {
                    subConjunto = subConjunto + ", [" + V[i] + "," + V[j] + "]";
                }

                if (i == V.Length - 1)
                {
                    ultimoSubConjunto = ultimoSubConjunto + V[i] + "]";
                    subConjunto = subConjunto + ultimoSubConjunto;
                }    
                else
                {
                    ultimoSubConjunto = ultimoSubConjunto + V[i] + ",";
                }
            }            

            Console.WriteLine(subConjunto);            
            Console.Read();*/
        }
    }
}
    

