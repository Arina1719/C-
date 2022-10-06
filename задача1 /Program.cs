
/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string firstNumber = Console.ReadLine();

Console.WriteLine("Введите второе число");
string secondNumber = Console.ReadLine(); 

int firstNum = int.Parse(firstNumber); 
int secondNum = int.Parse(secondNumber); 

if (firstNum < secondNum)
{
  Console.WriteLine($"Число {secondNum} является max, а число {firstNum} является min");
}

else if  (secondNum < firstNum)
   {
    Console.WriteLine($"Число {firstNum} является max, а число {secondNum} является min");
   }

