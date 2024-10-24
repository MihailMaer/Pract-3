


    
        int[,] matrix = { //Матрица
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        }; 
        
        int M = matrix.GetLength(0); //Возвращение строк и столбцов
        int N = matrix.GetLength(1);


        int middleRow = M / 2; //Нахождение середины матрицы
        int middleCol = N / 2;
        for (int i = 0; i < middleRow; i++)//Меняет элементы местами
        {
            for (int j = 0; j < middleCol; j++)
            {
                
                int temp = matrix[i, j]; //Сохраняет значение элемента

                
                matrix[i, j] = matrix[i + middleRow, j + middleCol];//Присваивает протовоположные значения

               
                matrix[i + middleRow, j + middleCol] = temp;
            }
        }

        
        for (int i = 0; i < M; i++) //Выводит результат
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    