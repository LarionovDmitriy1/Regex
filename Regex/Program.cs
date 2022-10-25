using System.Text.RegularExpressions;
void Number()
{
    Console.WriteLine("Введите номер телефона");
    string number = Console.ReadLine();
    Regex regex = new Regex(@"[7|8]{1}-\d{3}-\d{3}-\d{2}-\d{2}$");
    Regex regex1 = new Regex(@"[7|8]{1} \d{3} \d{3} \d{2} \d{2}$");
    Regex regex2 = new Regex(@"[7|8]\d{10}$");
    Regex regex3 = new Regex(@"[7|8]{1} \d{3} \d{3} \d{4}$");
    Regex regex4 = new Regex(@"[7|8]{1}-\d{3}-\d{3}-\d{4}$");
    if (Mail() == false)
    {
        return;
    }
    else if (regex.IsMatch(number))
    {
        Console.WriteLine("Молодец");
    }
    else if (regex1.IsMatch(number))
    {
        Console.WriteLine("Молодец");
    }
    else if (regex2.IsMatch(number))
    {
        Console.WriteLine("Молодец");
    }
    else if (regex3.IsMatch(number))
    {
        Console.WriteLine("Молодец");
    }
    else if (regex4.IsMatch(number))
    {
        Console.WriteLine("Молодец");
    }
    else
    {
        Console.WriteLine("Некоректный номер");
    }
}
bool Mail()
{
    Console.WriteLine("Введите почту");
    string mail = Console.ReadLine();
    Regex mail1 = new Regex(@"^[a-z]{1,20}@mail.ru$");
    if (!mail1.IsMatch(mail))
    {
        Console.WriteLine("Неверная почта");
        return false;
    }
    return true;
}
Number();



