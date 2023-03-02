// Программа, которая находит произведение пар чисел в массиве (первое-последнее)


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

//медод поиска произведения чисел
int [] CompozitionNumbers(int [] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size += 1;
    int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
    {
    newArray[i] = array[i]*array[array.Length -1 - i];
    }
    if (newArray.Length % 2 != 0) 
    newArray[newArray.Length - 1] = array[size - 1];
return newArray;
} 


int[] arr = CreateNewRndInt(5, 0, 10);
PrintArray(arr);
int[] compozition = CompozitionNumbers(arr);
Console.WriteLine();  
PrintArray(compozition);