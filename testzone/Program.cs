using System;
using System.Threading;

int total = 101;
int delay = 50;




List<string> menuItems =
    ["Get All",
    "Add",
    "Edit",
    "Exit"
];
ConsoleKeyInfo key;
int count = 0;
for (int i = 0; i < menuItems.Count; i++)
{
    if (i == count)
        Console.WriteLine($"> {menuItems[i]}");
    else Console.WriteLine(menuItems[i]);
}
while (true)
{
    key = Console.ReadKey();
    Console.Clear();
    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            count--;
            break;

        case ConsoleKey.DownArrow:
            count++;
            break;
        case ConsoleKey.Enter:
            if (count == 0) GetAll();
            else if (count == 1) AddMenu();
            else if (count == 3) return 0;
            break;

    }
    if (count < 0) count = menuItems.Count - 1;
    for (int i = 0; i < menuItems.Count; i++)
    {
        if (i == count % menuItems.Count)
            Console.WriteLine($"> {menuItems[i]}");
        else Console.WriteLine(menuItems[i]);
    }
}
void GetAll()
{
    for (int i = 0; i < total; i++)
    {
        Console.Clear();
        Console.CursorLeft = 0;
        Console.Write("Loading: [");
        Console.WriteLine($"{i}%]");
        Thread.Sleep(delay);
    }
    Console.Clear();
    Console.WriteLine("All autors");
}
void AddMenu()
{
    for (int i = 0; i < total; i++)
    {
        Console.Clear();
        Console.CursorLeft = 0;
        Console.Write("Loading: [");
        Console.WriteLine($"{i}%]");
        Thread.Sleep(delay);
    }
    Console.Clear();
    Console.WriteLine("Add Menu");
}
