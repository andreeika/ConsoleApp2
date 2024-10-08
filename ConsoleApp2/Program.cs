using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите m: ");
        int m= Convert.ToInt32(Console.ReadLine());


        // Инициализируем переменную для подсчета положительных элементов
        int positiveCount = 0;

        // Заполняем матрицу и подсчитываем положительные элементы
        for (int i = 1; i <= n; i++) // начиная с 1 по условию задачи
        {
            for (int j = 1; j <= m; j++) // начиная с 1 по условию задачи
            {
                double e_ij = Math.Sin((i + j) / 2.0);
                if (e_ij > 0)
                {
                    positiveCount++;
                }
            }
        }

        // Выводим результат
        Console.WriteLine($"Количество положительных элементов в матрице: {positiveCount}");
    }
}