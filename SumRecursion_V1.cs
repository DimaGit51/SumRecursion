using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRecursion_V1
{
    class SumRecursion_V1
    {
        static void Main(String[] args)
        {
            int n = 4; //Число ввода
            double result = 0; //Результат пока = 0
            double[] mass = new double[n]; //Создаем массив для дальнейшей передачи в рекурсивную функцию 
            for (int i = 0; i < n; i++)
            {
                mass[i] = 1;
            } //Заполняем массив 0
            result = RecursionSumm23(n, mass, result);//Запускаем рукурсивную функцию
            Console.WriteLine("Result = {0}", result); //Выводим результат
            Console.ReadKey(); //Нажать любую клавишу для выхода, чтобы сразу не закрылась консоль
        }
        static public double RecursionSumm23(int n, double[] mass, double result)
        {
            double returnResult = 0; //Переменная для возврата значения result

            if (n == 1) result = 1; //Если входное значение = 1, то это 1
            else //В остальных случая другие значиня
            {
                double sumn = 0; //Сумма чисел знаменателя
                for (int i = 0; i < mass.Length; i++) //Сумма знаменателя равна сумме элементов массива
                {
                    sumn += mass[i];
                }
                result += 1 / sumn; //Прибавляем к результату 1/сумму

                if (sumn < n * n) //Если сумма меньше чем n*n, то
                {

                    int z = mass.Length - 1; //Берем переменную, которой присваемваем номер последнего элемента массива
                    mass[z]++; //Прибавляем к последнему элементу массива еденицу
                    for (int j = z; j >= 1; j--) //Работаем с остальными элементами массива 
                    {
                        if (mass[j] > n)
                        {
                            mass[j] = 1;
                            mass[j - 1]++;
                        }

                    }
                    result = RecursionSumm23(n, mass, result); //Снова рекурсия
                    returnResult = result; //После всех рекурсий выводим результат в переменную для возврата результата
                }
                else
                {
                    returnResult = result; //Если сумма больше или равно n*n, то выводим результат в переменную возврата
                }
            }
            return returnResult; //return
        }
    }
}
