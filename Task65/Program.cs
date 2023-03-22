// Программа, которая принимает числа M, N, 
// и выводит все натуральные числа от M до N
Console.WriteLine ("Введите любое натуральное число");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите любое натуральное число");
int numberN = int.Parse(Console.ReadLine());
if(numberM < numberN)
{
NaturalNumbersFromMtoN(numberM, numberN);

void NaturalNumbersFromMtoN(int numM, int numN)
{
    if(numN < numM) return;
    NaturalNumbersFromMtoN(numM, numN - 1);
    Console.Write($"{numN} ");
    
}
}
else Console.WriteLine ("Первое число должно быть меньше второго");