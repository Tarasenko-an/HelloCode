//Вводим первое число
Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

//Вводим второе число
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//Проверяем на условие и выводим результат
if (num1*num1 == num2)
   {
        Console.WriteLine("Да");
   } 
else
    {
        Console.WriteLine("Нет");
    }    