public static void Main(string[] args)
    {
        // Ввод данных
        int M = 3; // Число строк
        int N = 4; // Число столбцов
        int D = 2; // Разность арифметической прогрессии
        int[] numbers = { 1, 3, 5 }; // Исходный набор чисел

       

        // Создание матрицы
        int[,] matrix = new int[M, N];

        // Заполнение первого столбца матрицы
        for (int i = 0; i < M; i++)
        {
            matrix[i, 0] = numbers[i];
        }

        // Заполнение остальных столбцов матрицы
        for (int i = 0; i < M; i++)
        {
            for (int j = 1; j < N; j++)
            {
                matrix[i, j] = matrix[i, j - 1] + D;
            }
        }

        // Вывод матрицы
        Console.WriteLine("Матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
