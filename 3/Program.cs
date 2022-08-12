int num; 

while (true)
{
    Console.Write("Введите день недели, число от 1 до 7: ");
    if (int.TryParse(Console.ReadLine(), out num) && num > 0 && num < 8)
           
    break;
    Console.WriteLine("Ошибка ввода! Введите число от 1 до 7!");
}

if (num > 5 ) 
{
    Console.WriteLine($"Введено число = {num} -> выходной");        
}
else    
{
    Console.WriteLine($"Введено число = {num} -> будний день");
}
