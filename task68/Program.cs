// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое неотрицательное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int functionsAckerman=AckermanFunctions(number1,number2);
 Console.WriteLine(functionsAckerman); 


 int AckermanFunctions(int num1,int num2)
{
  if (num1 == 0)
    return num2 + 1;
  else
    if ((num1 != 0) && (num2 == 0))
      return AckermanFunctions(num1 - 1, 1);
    else
      return AckermanFunctions(num1 - 1, AckermanFunctions(num1, num2 - 1));
}