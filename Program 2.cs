

int K = 3; // Задаем номер серии, которую нужно удвоить
int[] array = { 1, 1, 2, 2, 2, 3, 4 }; // Исходный массив
int N = array.Length; // Размер массива

// Переменные для хранения информации о текущей серии
int Element = array[0];
int Length = 1;

List<int> Array = new List<int>(); // Создаем список для модифицированного массива

for (int i = 1; i < N; i++)
{
    if (array[i] == Element)
    {
        Length++; // Увеличиваем длину текущей серии
    }
    else
    {
        if (Length >= K)
        {
            // Добавляем все элементы текущей серии еще раз
            for (int j = 0; j < Length; j++)
            {
                Array.Add(Element);
            }
        }
        else
        {
            // Просто добавляем элементы текущей серии в новый массив
            for (int j = 0; j < Length; j++)
            {
                Array.Add(Element);
            }
        }

        Element = array[i]; // Обновляем текущий элемент
        Length = 1; // Сбрасываем длину текущей серии
    }
}

if (Length >= K) // Если последняя серия имеет номер K
{
    for (int j = 0; j < Length; j++)
    {
        Array.Add(Element); // Добавляем все элементы последней серии еще раз
    }
}

if (Array.Count == 0) // Если не было серий с номером K
{
    Console.WriteLine("Массив без изменений:");
    foreach (var num in array)
    {
        Console.Write(num + " ");
    }
}
else
{
    Console.WriteLine("Модифицированный массив:");
    foreach (var num in Array)
    {
        Console.Write(num + " ");
    }
}