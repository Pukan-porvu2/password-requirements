using System;
using System.Linq;

class Password
{
    public string Pass { get; set; }

    static string[] levels = new string[] { "", "низкая", "средняя", "высокая", "очень высокая" };

    public Password(string p = "") { Pass = p; }

    public void Input()
    {
        string s;

        do
        {
            Console.WriteLine("Введите пароль (не менее 5 символов): ");
            s = Console.ReadLine();
        }
        while (s.Length < 5);

        Pass = s;
    }

    public string Security()
    {
        int result = 0;

        if (Pass.Length >= 5) result++;
        if (Pass.Length >= 8) result++;
        if (Pass.Any(x => char.IsUpper(x))) result++;
        if (Pass.Any(x => char.IsDigit(x))) result++;

        return levels[result];
    }
}

class Program
{
    static void Main()
    {
        Password p = new Password();
        p.Input();
        Console.WriteLine("Надежность пароля: {0}", p.Security());
        Console.ReadKey();
    }
}