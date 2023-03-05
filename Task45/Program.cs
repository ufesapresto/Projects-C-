// Программа, которая создает массив из путем копирования элементов
// исходного массива

int[] CreateNewRndInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
// метод копирования массива
int[] CopyArr (int [] arr)
{
    int [] copyArray = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}


// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)Console.Write(",");
    }
    Console.WriteLine("]");
} 
//медод поиска количества чисел


int[] newArray = CreateNewRndInt(10, 0, 9);
PrintArray(newArray);
int[] copyArr = CopyArr(newArray);
PrintArray(copyArr);

