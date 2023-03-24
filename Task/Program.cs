// Задача
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Задаем массив строк и объявляем второй, куда будут заноситься строки согласно условию
string[] arrInitial = {"Hello!", "Hi!", "123", "May", "77", "April27", "end", "finish"};
string[] arrFinal = new string[arrInitial.Length];

// Метод формирования массива строк из исходного массива, длина которых соответствует условию (<=3)
void CreateFinalArray(string[] arr1, string[] arr2)
{
    int index = 0;
    for (int i = 0; i < arr1.Length; i ++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[index] = arr1[i];
            index ++;
        }
    }
}

// Метод вывода массива
void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]}"+" ");
    }
    Console.WriteLine();
}

PrintArr(arrInitial);
CreateFinalArray(arrInitial, arrFinal);
PrintArr(arrFinal);