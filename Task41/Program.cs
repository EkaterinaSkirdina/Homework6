/* Задача 41. Пользователь вводит с клавиатуры М чисел.
Пoсчитайте, сколько чисел больше 0 ввёл пользователь.*/

void Main()
{
    int i = GetAmountOfInput();
    int count = CountPositiveNumbers(i);
    OutPut(count);
}

int GetAmountOfInput()
{
    Console.WriteLine("Введите колличество чисел: ");
    int amount = int.Parse(Console.ReadLine());
    return amount;
}

int CountPositiveNumbers(int inputQuantity)
{
    int countPosNum = 0;
    for (int i = 0; i < inputQuantity; i++)
    {
        Console.WriteLine($"Введите число{i + 1}: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            countPosNum++;
        }
    }
    return countPosNum;
}

void OutPut(int arg)
{
    Console.WriteLine();
    Console.WriteLine(arg);
}

Main();
