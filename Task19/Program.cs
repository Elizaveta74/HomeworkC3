/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
string enteredString = Console.ReadLine();
/*
Проверяем, является ли введенная в переменную enteredString строка
целым числом. Если является, то TryParse вернет true и в out-параметре
number у нас окажется сконвертированное число из строки в переменной 
enteredString.
*/  
if (int.TryParse(enteredString, out int number)) 
{
    if (number > 9999 && number < 100000)
    {
        char s0 = enteredString[0]; //char - символьный тип
        char s1 = enteredString[1];
        char s3 = enteredString[3];
        char s4 = enteredString[4];

        /* Делаем сравнение с помощью ==
        т.к. компьютер сравнивает коды символов,
        которые записаны в переменных с типом char.
        */

        if (s0 == s4 && s1 == s3) 
        {
            Console.Write("да");
        }
        else
        {
            Console.Write("нет");
        }
    } 
    else
    {
        Console.Write("Вы ввели не пятизначное число");
    }
}
else
{
    Console.Write("Ожидался ввод пятизначного числа без пробелов, " +
                                        $"а вы ввели '{enteredString}'");
}


