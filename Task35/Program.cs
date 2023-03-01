// Программа, которая создает массив из 123 чисел и 
// определяет количество элементов массива в диапазоне от 10 до 99

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
//медод поиска количества чисел
int QuantityNumbers(int [] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
    {
    if (array[i] >= 10 && array[i] <= 99) count++;
    }
return count;
} 


int[] arr = CreateNewRndInt(123, 0, 1000);
PrintArray(arr);
int quantity = QuantityNumbers(arr);
Console.WriteLine(quantity);  
