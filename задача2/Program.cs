/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string firstNumber = Console.ReadLine(); 

Console.WriteLine("Введите второе число");
string secondNumber = Console.ReadLine(); 

Console.WriteLine("Введите третье число");
string thirdNumber = Console.ReadLine(); 

int firstNum = int.Parse(firstNumber); 
int secondNum = int.Parse(secondNumber); 
int thirdNum = int.Parse(thirdNumber); 

if ((secondNum>firstNum) && (secondNum>thirdNum))
{
   Console.WriteLine($"Число {secondNum} является max");  
}
else if ((firstNum>secondNum) && (firstNum>thirdNum))
{
   Console.WriteLine($"Число {firstNum} является max");  
}
else if ((thirdNum>secondNum) && (thirdNum>firstNum))
{
   Console.WriteLine($"Число {thirdNum} является max");  
}

  




