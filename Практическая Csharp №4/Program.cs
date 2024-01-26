int day = 1;
int pos = 1;
ConsoleKeyInfo key;
do
{
    Console.Clear();
    Date();
    Strelochka();
} while (key.Key != ConsoleKey.Escape);


void Strelochka()
{
    Console.SetCursorPosition(0, pos);
    Console.WriteLine("->");

    key = Console.ReadKey();

    Console.SetCursorPosition(0, pos);
    Console.WriteLine(" ");

    if (key.Key == ConsoleKey.UpArrow && pos != 1)
    {
        pos--;
    }
    else if (key.Key == ConsoleKey.DownArrow && pos != 2)
    {
        pos++;
    }
    else if (key.Key == ConsoleKey.LeftArrow && day != 1)
    {
        day--;
    }
    else if (key.Key == ConsoleKey.RightArrow && day != 31)
    {
        day++;
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        DetailedInfo(day, pos);
    }
}

void Date()
{
    if (day < 10)
    {
        Console.WriteLine("Выбрана дата: " + "0" + day + ".01.2024");
    }
    else if (day >= 10)
    {
        Console.WriteLine("Выбрана дата: " + day + ".01.2024");
    }

    switch (day)
    {
        case 1:
            Console.WriteLine("  1. Сделать домашку");
            Console.WriteLine("  2. Поиграть в Dead by Daylight");
            break;

        case 2:
            Console.WriteLine("  1. Убраться в комнате");
            Console.WriteLine("  2. Посмотреть YouTube");
            break;

        case 3:
            Console.WriteLine("  1. Пойти на пары");
            Console.WriteLine("  2. Проспать пары");
            break;
    }
}

void DetailedInfo(int day, int pos)
{
    do
    {
        Console.Clear();
        if (day == 1 && pos == 1)
        {
            Console.WriteLine("Сделать домашку");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: Сделать практосы по питону и сишарпу");
            Console.WriteLine("Дата: " + "0" + day + ".01.2024" + " 00:00:00");
        }
        else if (day == 1 && pos == 2)
        {
            Console.WriteLine("Поиграть в Dead by Daylight");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: Зайти в Dead by Daylight, загрузиться в катку, получить хит через паллету, закрыть Dead by Daylight");
            Console.WriteLine("Дата: " + "0" + day + ".01.2024" + " 00:00:00");
        }
        else if (day == 2 && pos == 1)
        {
            Console.WriteLine("Убраться в комнате");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: Заправить кровать, подмести пол, протереть пыль");
            Console.WriteLine("Дата: " + "0" + day + ".01.2024" + " 00:00:00");
        }
        else if (day == 2 && pos == 2)
        {
            Console.WriteLine("Посмотреть YouTube");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: С 10:00 до 00:00");
            Console.WriteLine("Дата: " + "0" + day + ".01.2024" + " 00:00:00");
        }
        else if (day == 3 && pos == 1)
        {
            Console.WriteLine("Пойти на пары");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: Поспать в электричке, приехать в техникум, поспать на парах, поехать домой");
            Console.WriteLine("Дата: " + "0" + day + ".01.2024" + " 00:00:00");
        }
        else if (day == 3 && pos == 2)
        {
            Console.WriteLine("Проспать пары");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Описание: С первой по седьмую");
            Console.WriteLine("Дата: " + "0" + day + ".01.2024" + " 00:00:00");
        }
        else
        {
            break;
        }
        key = Console.ReadKey();
    } while (key.Key != ConsoleKey.Enter);
}