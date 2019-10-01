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

            int[] lista = new int[4] { 10, 15, 3, 7 };     //Array inicia na posição 0
            int k = 17;                                    //Variável utilizada na comparação com a soma
            string retorno = "";                           //Variável para imprimir o retorno TRUE

            //Primeiro for: percorre cada elemento da lista de valores
            for (int i = 0; i < lista.Length; i++)
            {
                //Segundo for: utilizado para somar cada elemento da posição i com os demais elementos da
                //lista de valores
                for (int j = i + 1; j < lista.Length; j++)
                {
                    //IF para comparar se a soma de dois valores da lista é igual a k
                    if (k == lista[i] + lista[j])
                    {
                        //Quando a comparação for igual, então faz o retorno TRUE
                        retorno = retorno + "TRUE ==> " + lista[i].ToString() + " + " + lista[j].ToString() + " = " + 
                                  k.ToString() + "\n";
                    }
                }
            }

            //Imprime os subconjuntos na tela
            Console.WriteLine(retorno);
            Console.Read();

            /*=================================================================================================*/

            /* 2. Dado um array de inteiros, devolva um novo array onde cada elemento na posição i 
             * do novo array é o produto de todos os valores do array original exceto o elemento na posição i.
             * Por exemplo, se forem informados os valores [1,2,3,4,5], o resultado esperado deve ser igual
             * a [120,60,40,30,24]. Se informamos os valores [3,2,1], e espera-se como resposta os valores
             * [2,3,6]. */

            /*int[] original = new int[5] { 1, 2, 3, 4, 5 };    //Array inicia na posição 0
            int[] produto = new int[5];                       //Array inicia na posição 0
            int multiplicacao;                                //Variável para auxiliar na multiplicação dos
                                                              //elementos do Array
            //Primeiro for: percorre cada elemento do array
            for (int i = 0; i < original.Length; i++)  
            {
                //Cada vez que o for muda na posição i, a variável multiplicação é inicializada com 1 
                //para o novo cálculo
                multiplicacao = 1;

                //Segundo for: utilizado para multiplicar os elementos exceto o da posição m.
                for (int m = 0; m < original.Length; m++)
                {
                    //IF se a posição i é igual a posição m, então passa para o próximo elemento
                    if (i == m)
                    {
                        continue;                       
                    }
                    else
                    {
                        //Variável multiplicacao para realizar o produto dos elementos do array
                        multiplicacao = multiplicacao * original[m];
                    }
                }

                //Grava o valor da multiplicação no novo array
                produto[i] = multiplicacao;
            }

            //Imprime os subconjuntos na tela
            Console.WriteLine(string.Join(", ", produto));
            Console.Read();*/

            /*=================================================================================================*/

            /* 3. Considere uma escadaria com n degraus e você pode subir 1 ou 2 degraus por vez. 
             * Dado n, retorne o número de maneiras únicas de subir a escada. Por exemplo, dado n = 4, 
             * existem 5 maneiras exclusivas: [1,1,1,1], [2,1,1], [1,2,1], [1,1,2], [2,2] */

            /*int degraus = 4;
            int degrauUm = 1;
            int degrauDois = 2;                      
            string primeiraCombinacao = "";
            string demaisCombinacoes = "";
            string ultimaCombinacao = "";            
            string[] combinacoes = new string[5];

            //FOR para percorrer cada degrau da escadaria
            for (int i = 0; i < degraus; i++)
            {
                //IF para montar a primeira combinação de degraus na posição i
                //Todos os elementos são compostos pelo degrau de 1 em 1
                if (i == 0)
                {
                    //FOR para montar a primeira combinação de degraus
                    for (int j = 0; j < degraus; j++)
                    {
                        //IF para identificar se é a última leitura no FOR da posição j
                        if (j == degraus - 1)
                        {
                            //Última leitura do FOR, então não adiciona vírgula ao final
                            primeiraCombinacao = "[" + primeiraCombinacao + degrauUm + "]";
                        }
                        else
                        {
                            //Enquanto não for a última leitura no FOR, então adiciona vírgula ao final
                            primeiraCombinacao = primeiraCombinacao + degrauUm + ",";
                        }
                    }

                    //Adiciona no array a primeira combinação de degraus
                    combinacoes[i] = primeiraCombinacao;
                }
                //Montar os elementos das demais combinações
                else
                {
                    //Cada vez que o for muda na posição i, a variável demaisCombinacoes é inicializada com  
                    //branco para a nova combinação
                    demaisCombinacoes = "";

                    //FOR para montar as demais combinações de degraus
                    for (int j = 1; j < degraus; j++)
                    {
                        //IF para identificar se a posição j é igual a posição i                        
                        if (j == i)
                        {
                            //São iguais, então coloca o degrau de 2 em 2
                            demaisCombinacoes = demaisCombinacoes + degrauDois.ToString() + ",";
                        }
                        else
                        {
                            //Não são iguais, então coloca o degrau de 1 em 1
                            demaisCombinacoes = demaisCombinacoes + degrauUm.ToString() + ",";
                        }

                        //IF para identificar se é a última leitura no FOR da posição j
                        if (j == degraus - 1)
                        {
                            //Coloca os colchetes para identificar a nova combinação
                            demaisCombinacoes = "[" + demaisCombinacoes + "]";
                        }                        
                    }

                    //Adiciona no array a combinação formada
                    combinacoes[i] = demaisCombinacoes;
                }

                //IF para montar a última combinação de degraus na posição i
                //Todos os elementos são compostos pelo degrau de 2 em 2
                if (i == degraus - 1)
                {
                    //FOR para montar a última combinação de degraus
                    for (int j = 2; j < degraus; j++)
                    {
                        //IF para identificar se é a última leitura no FOR da posição j
                        if (j == degraus - 1)
                        {
                            //Última leitura do FOR, então não adiciona vírgula ao final
                            ultimaCombinacao = "[" + ultimaCombinacao + degrauDois + "]";
                        }
                        else
                        {
                            //Enquanto não for a última leitura no FOR, então adiciona vírgula ao final
                            ultimaCombinacao = ultimaCombinacao + degrauDois + ",";
                        }
                    }

                    //Adiciona no array a última combinação de degraus
                    combinacoes[i + 1] = ultimaCombinacao;
                }
            }

            //Imprime as combinações na tela
            Console.WriteLine(string.Join(", ", combinacoes));
            Console.Read();*/      

            /*=================================================================================================*/

            /* 4. Power set é um conjunto gerado a partir da combinação de todos os seus subconjuntos.
             * Dado um conjunto V, retorne o power set deste conjunto de entrada. Por exemplo, 
             * dado V = [1,2,3], a saída deve ser igual a [], [1], [2], [3], [1,2], [1,3], [2,3], [1,2,3] */

            /*int[] V = new int[3] { 1, 2, 3 };      //Array inicia na posição 0          
            string subConjunto = "[]";             //Variável que armazena os subconjuntos 
            string ultimoSubConjunto = ", [";      //Variável que armazena o último subconjunto

            //Primeiro for: percorre cada elemento do conjunto V
            for (int i = 0; i < V.Length; i++)
            {
                //Adiciona no array os subconjuntos de um elemento [1], [2], [3]
                subConjunto = subConjunto + ", [" + V[i] + "]";

                //Segundo for: agrupa dois elementos para formar subconjuntos
                for (int j = i + 1; j < V.Length; j++)
                {
                    //[1,2], [1,3], [2,3]
                    subConjunto = subConjunto + ", [" + V[i] + "," + V[j] + "]";
                }

                //IF para formar o último subconjunto [1,2,3]
                if (i == V.Length - 1)
                {
                    //Última leitura do FOR, então não adiciona vírgula ao final
                    ultimoSubConjunto = ultimoSubConjunto + V[i] + "]";
                    subConjunto = subConjunto + ultimoSubConjunto;
                }    
                else
                {
                    //Enquanto não for a última leitura no FOR, então adiciona vírgula ao final
                    ultimoSubConjunto = ultimoSubConjunto + V[i] + ",";
                }
            }            

            //Imprime os subconjuntos na tela
            Console.WriteLine(subConjunto);            
            Console.Read();*/

            /*=====NOVO=====*/
            /*int conjuntoV = 3;                           //Variável contém o número de elementos do conjunto V
            List<string> powerSet = new List<string>();  //Lista inicia na posição 1
            string ultimoSubConjunto = "";               //Variável que armazena o último subconjunto

            //Adiciona na lista o subconjunto []
            powerSet.Add("[]");            

            //Primeiro for: percorre cada elemento do conjunto V
            for (int i = 1; i < conjuntoV + 1; i++)
            {
                //Adiciona na lista os subconjuntos de um elemento [1], [2], [3]
                powerSet.Add("[" + i.ToString() + "]");                

                //Segundo for: agrupa dois elementos para formar subconjuntos 
                for (int j = i + 1; j < conjuntoV + 1; j++)
                {
                    //[1,2], [1,3], [2,3]
                    powerSet.Add("[" + i.ToString() + "," + j.ToString() + "]");                    
                }

                //IF para formar o último subconjunto [1,2,3]
                if (i == conjuntoV)
                {
                    //Última leitura do FOR, então não adiciona vírgula ao final
                    ultimoSubConjunto = ultimoSubConjunto + i.ToString();
                }
                else
                {
                    //Enquanto não for a última leitura no FOR, então adiciona vírgula ao final
                    ultimoSubConjunto = ultimoSubConjunto + i.ToString() + ",";
                }                                  
            }

            //Adiciona na lista o subconjunto [1,2,3]
            powerSet.Add("[" + ultimoSubConjunto + "]");
            
            foreach (string subConjunto in powerSet)
            {          
                //Imprime os subconjuntos na tela
                Console.WriteLine(subConjunto.ToString());                
            }

            Console.Read();*/
        }
    }
}