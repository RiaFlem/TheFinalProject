System.Console.WriteLine ("Введите количество элементов от 0 до 3: ");
int num = Convert.ToInt32 (Console.ReadLine ());
string [] result = new string [num];
string [] str1 = {"Hello", "2", "world", ":-)"};
string [] str2 = {"1234", "1567", "-2", "computer science"};
string [] str3 = {"Russia", "Denmark", "Kazan"};

String [] ChangeString (int n, string [] str)
{
    for (int i = 0; i < result.Length; i++)
    {
        result [i] = str [i];
    }
    return result;
}

void PrintString (string [] res, int n)
{
    if (n >= 0 && n <= 3)
    {
        System.Console.Write ("[");
        for (int i = 0; i < res.Length; i++)
        {
            System.Console.Write (res [i]);
            if (i < n - 1)
            {
                System.Console.Write (", ");
            }
        }
        System.Console.Write ("]");
    }
    else 
    {
        System.Console.WriteLine ("Неправильный ввод!");
    }
}

result = ChangeString (num, str2);
PrintString (result, num);
