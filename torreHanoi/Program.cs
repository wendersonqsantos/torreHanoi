using System;
using System.Collections.Generic;

namespace torreHanoi
{
    class Program
    {
        public static Stack<int> gerar(Stack<int> hanoi)
        {
            int num,quantidade;
            Console.WriteLine("informe o tamanho da torre a ser gerada: ");
            quantidade = int.Parse(Console.ReadLine());
            num = quantidade;
            while (hanoi.Count < quantidade)
            {
                hanoi.Push(num);
                num--;
            }
            return hanoi;

        }
        public static void torreHanoi(int tamanho, Stack<int> hanoi, Stack<int> resultante, Stack<int> auxiliar)
        {
            if (tamanho > 0)
            {
                torreHanoi(tamanho - 1, hanoi, auxiliar, resultante);
                resultante.Push(hanoi.Pop());
                torreHanoi(tamanho - 1, auxiliar, resultante, hanoi);
            }
        }
        public static void imprimir(Stack<int> hanoi)
        {
            foreach (var item in hanoi)
            {
             
                Console.WriteLine(""+item);
            }
        }
        static void Main(string[] args)
        {
            Stack<int> hanoi = new Stack<int>();
            Stack<int> auxiliar = new Stack<int>();
            Stack<int> result = new Stack<int>();
            gerar(hanoi);
            Console.Clear();
            Console.WriteLine("Torre Gerada:");
            imprimir(hanoi);
            torreHanoi(hanoi.Count, hanoi, result,auxiliar);
            Console.WriteLine("Torre de Hanoi: ");
            imprimir(result);
            Console.ReadKey();
        }
    }
}
