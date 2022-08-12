int num; 

while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out num))
           
    break;
    Console.WriteLine("Ошибка ввода! Введите число!");
}

if (num < 100 && num > -100) 
{
    Console.WriteLine($"Введено число = {num}, третья цифра отсутствует!");        
}
else    
{
    Console.WriteLine($"Введено число = {num}");
    Console.WriteLine($"Третья цифра числа = {num.ToString()[2]}");
}



