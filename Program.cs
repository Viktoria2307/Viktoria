// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

void SecondNumber ()
{
    Console.Write("Напишите любое трехзначное число: ");
            int num = int.Parse(Console.ReadLine());
            int x1 = num%100;
            int result = x1/10;
    Console.WriteLine(result);
}

SecondNumber ();











