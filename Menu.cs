public static class Menu
{
    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.Write("HTML Editor");
        Console.SetCursorPosition(3, 3);
        Console.Write("-------------------------");
        Console.SetCursorPosition(3, 4);
        Console.Write("Choose an option");
        Console.SetCursorPosition(3, 6);
        Console.Write("1 - New file");
        Console.SetCursorPosition(3, 7);
        Console.Write("2 - Open existing file");
        Console.SetCursorPosition(3, 8);
        Console.Write("0 - Exit");
        Console.SetCursorPosition(3, 10);
        Console.Write("Select: ");

    }
    public static void DrawScreen()
    {
        Console.Write("+");
        for (int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");

        for (int lines = 0; lines <= 10; lines++)
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }

        Console.Write("+");
        for (int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
    }

    public static void handleMenuOptions(int option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
        }
    }
    public static void Show()
    {

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        DrawScreen();
        WriteOptions();
        var option = int.Parse(Console.ReadLine());
        handleMenuOptions(option);
    }
}