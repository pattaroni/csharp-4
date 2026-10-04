using System;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
    }

    // завдання 1
    static void Task1()
    {
        Console.WriteLine("Завдання 1");

        Book book1 = new Book();
        book1.Title = "Кобзар";
        book1.Author = "Тарас Шевченко";
        book1.Year = 1840;

        Book book2 = new Book();
        book2.Title = "Тіні забутих предків";
        book2.Author = "Михайло Коцюбинський";
        book2.Year = 1911;

        Book book3 = new Book();
        book3.Title = "1984";
        book3.Author = "Джордж Орвелл";
        book3.Year = 1949;

        Book[] books = { book1, book2, book3 };

        foreach (Book b in books)
        {
            Console.WriteLine(b.Title + " - " + b.Author + ", " + b.Year + " рік");
        }
    }

    // завдання 2
    static void Task2()
    {
        Console.WriteLine("Завдання 2");

        Student s1 = new Student();
        s1.FirstName = "Олексій";
        s1.LastName = "Кирик";
        s1.BirthYear = 2007;

        Student s2 = new Student();
        s2.FirstName = "Марія";
        s2.LastName = "Іванова";
        s2.BirthYear = 2003;

        Student s3 = new Student();
        s3.FirstName = "Андрій";
        s3.LastName = "Петров";
        s3.BirthYear = 2005;

        Student[] students = { s1, s2, s3 };

        int totalAge = 0;
        foreach (Student s in students)
        {
            int age = s.GetAge();
            totalAge += age;
            Console.WriteLine(s.FirstName + " " + s.LastName + " - " + age + " років");
        }

        double averageAge = (double)totalAge / students.Length;
        Console.WriteLine("Середній вік: " + averageAge);
    }

    // завдання 3
    static void Task3()
    {
        Console.WriteLine("Завдання 3");

        User user = new User();
        user.Login = "pattaroni";
        user.Password = "qwerty123";

        user.PrintInfo();

        user.ChangeBalance(500);
        Console.WriteLine("Поповнено на 500 грн");
        user.PrintInfo();
    }

    // завдання 4
    static void Task4()
    {
        Console.WriteLine("Завдання 4");

        string[] firstNames = { "Олексій", "Марія", "Андрій" };
        string[] lastNames = { "Кирик", "Іванова", "Петров" };

        string[] fullNames = CombineNames(firstNames, lastNames);

        foreach (string name in fullNames)
        {
            Console.WriteLine(name);
        }
    }

    static string[] CombineNames(string[] firstNames, string[] lastNames)
    {
        string[] result = new string[firstNames.Length];
        for (int i = 0; i < firstNames.Length; i++)
        {
            result[i] = lastNames[i] + ", " + firstNames[i];
        }
        return result;
    }

    // завдання 5
    static void Task5()
    {
        Console.WriteLine("Завдання 5");

        string[] words = { "кіт", "комп'ютер", "дім", "клавіатура", "ніч" };

        string longest = FindLongestWord(words);
        Console.WriteLine("Найдовше слово: " + longest);
    }

    static string FindLongestWord(string[] words)
    {
        string longest = words[0];
        foreach (string w in words)
        {
            if (w.Length > longest.Length)
            {
                longest = w;
            }
        }
        return longest;
    }
}
