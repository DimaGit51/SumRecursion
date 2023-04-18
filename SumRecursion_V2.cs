using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRecursion_V2
{
    class SumRecursion_V2
    {
        static void Main(String[] args)
        {
            int n = 4; //Число ввода
            int k = 0; 
            double result = 0; //Результат пока = 0
            result = RecursionSumm23(n, k, result); //Запускаем рукурсивную функцию
            Console.WriteLine("Result = {0}", result); //Выводим результат
            Console.ReadKey(); //Нажать любую клавишу для выхода, чтобы сразу не закрылась консоль
        }
        //В данной рекурсии происходит перевод числа k в число другой сист.счисл. n в рекурс функции DecTo
        //Далее такая же логика как и в 1 версии решения, только число преобразуется из сист.счисл n для удобной работы
        static public double RecursionSumm23(int n, int k, double result)
        {
            double returnResult = 0;
            if (n == 1) returnResult = 1;
            else
            {
                if (k < Math.Pow(n, n))
                {
                    string str1 = DecTo(k, n);
                    while ((str1.Length) < n) str1 = '0' + str1;
                    string str2 = "";
                    for (int i = 0; i < str1.Length; i++)
                    {
                        str2 += (double.Parse(str1[i].ToString()) + 1).ToString();
                    }
                    double SummaZnam = 0;
                    for (int i = 0; i < str2.Length; i++)
                    {
                        SummaZnam += double.Parse(str2[i].ToString());
                    }
                    k++;

                    result = RecursionSumm23(n, k, result);
                    result += 1 / SummaZnam;
                    returnResult = result;
                }
                else returnResult = result;
            }
            return returnResult;
        }
        static string DecTo(int n, int k)
        {
            string x;
            if (n == 0) x = "0";
            if (n / k > 0) x = DecTo(n / k, k) + (char)(n % k + '0');
            else x = "" + (char)(n % k + '0');
            return x;
        }
    }
}
