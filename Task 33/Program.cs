// Программа, которая сождает массив и определяет, 
// находится ли в массиве заданное число

//метод создания массива
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
    Console.Write("]");
} 
//медод поиска числа в массиве
bool FindNumberArray(int [] array, int n)
{
for (int i = 0; i < array.Length; i++)
    {
    if (array[i] == n) return true;
    }
return false;
} 

Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateNewRndInt(25, -9, 9);
PrintArray(arr);
bool existNum = FindNumberArray(arr, num);
Console.WriteLine(existNum ? " -> Да" : " -> Нет");   //!!!Тернарный оператор