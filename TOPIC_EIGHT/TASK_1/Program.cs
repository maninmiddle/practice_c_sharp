using System;

public class Program 
{
    public static void Main()
    {
        CommandManager manager = new CommandManager();

        Command cmd1 = new Command("Добавить текст");
        Command cmd2 = new Command("Удалить строку");
        Command cmd3 = new Command("Изменить цвет");

        manager.Execute(cmd1);
        manager.Execute(cmd2);
        manager.Execute(cmd3);

        Console.WriteLine();

        manager.Undo();
        manager.Undo();

        Console.WriteLine();

        manager.Redo();
        manager.Redo();

        Console.WriteLine();

        manager.Undo();
    }
}