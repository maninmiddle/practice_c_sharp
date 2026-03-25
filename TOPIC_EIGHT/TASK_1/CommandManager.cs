using System;

public class CommandManager
{
    private Stack<Command> undoStack = new Stack<Command>();
    private Stack<Command> redoStack = new Stack<Command>();

    public void Execute(Command command)
    {
        command.Execute();
        undoStack.Push(command);
        redoStack.Clear();
    }

    public void Undo()
    {
        if (undoStack.Count == 0)
        {
            Console.WriteLine("Нет команд для отмены.");
            return;
        }

        Command command = undoStack.Pop();
        command.Undo();
        redoStack.Push(command);
    }

    public void Redo()
    {
        if (redoStack.Count == 0)
        {
            Console.WriteLine("Нет команд для повторного выполнения.");
            return;
        }

        Command command = redoStack.Pop();
        command.Execute();
        undoStack.Push(command);
    }
}