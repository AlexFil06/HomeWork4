// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16


Console.Write("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для возведения в степень ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)      // как я понял, то нельзя было использовать Math.Pow в этом задании, поэтому такое решение. 
{
    int result = 1;
    if (num2 < 0) num2 = num2 * -1;
    for (int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}

int result = Exponentiation(numberA, numberB);
Console.Write(result);