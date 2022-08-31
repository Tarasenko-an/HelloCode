//Вводим число

Console.Write("Введите номер дня (1-7): ");
int num1 = Convert.ToInt32(Console.ReadLine());

//Выводим день недели
switch(num1)
{
    case 1:
    Console.WriteLine("Понедельник");
    break;

    case 2:
    Console.WriteLine("Вторник");
    break;

    case 3:
    Console.WriteLine("Среда");
    break;

    case 4:
    Console.WriteLine("Четверг");
    break;

    case 5:
    Console.WriteLine("Пятница");
    break;

    case 6:
    Console.WriteLine("Суббота");
    break;

    case 7:
    Console.WriteLine("Воскресение");
    break;

    default:
    Console.WriteLine("Число не входит в диапазон 1..7");
    break;

}