using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using AvaloniaApplication1.ViewModels;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    private MainWindowViewModel Vm => (MainWindowViewModel)DataContext!;

    private async void AddProduct_Click(object? sender, RoutedEventArgs e)
    {
        var window = new AddProductWindow();

        await window.ShowDialog(this);

        if (window.Product != null)
        {
            Vm.Products.Add(window.Product);
        }
    }

    private async void EditProduct_Click(object? sender, RoutedEventArgs e)
    {
        if (Vm.SelectedProduct == null)
        {
            await ShowInfoDialog("Внимание", "Сначала выберите товар.");
            return;
        }

        Vm.EditProduct();
        await ShowInfoDialog("Успех", "Товар отредактирован.");
    }

    private async void DeleteProduct_Click(object? sender, RoutedEventArgs e)
    {
        if (Vm.SelectedProduct == null)
        {
            await ShowInfoDialog("Внимание", "Сначала выберите товар.");
            return;
        }

        bool confirmed = await ShowConfirmDialog("Подтверждение", "Удалить выбранный товар?");
        if (confirmed)
        {
            Vm.DeleteSelectedProduct();
        }
    }

    private void ExitMenuItem_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private async void Settings_Click(object? sender, RoutedEventArgs e)
    {
        await ShowInfoDialog("Настройки", "Окно настроек пока не реализовано.");
    }

    private async Task<bool> ShowConfirmDialog(string title, string message)
    {
        var dialog = new Window
        {
            Title = title,
            Width = 350,
            Height = 160,
            WindowStartupLocation = WindowStartupLocation.CenterOwner,
            Background = Avalonia.Media.Brushes.White
        };

        bool result = false;

        var textBlock = new TextBlock
        {
            Text = message,
            Margin = new Avalonia.Thickness(10),
            Foreground = Avalonia.Media.Brushes.Black
        };

        var yesButton = new Button
        {
            Content = "Да",
            Width = 80,
            Margin = new Avalonia.Thickness(5)
        };

        var noButton = new Button
        {
            Content = "Нет",
            Width = 80,
            Margin = new Avalonia.Thickness(5)
        };

        yesButton.Click += (_, _) =>
        {
            result = true;
            dialog.Close();
        };

        noButton.Click += (_, _) =>
        {
            result = false;
            dialog.Close();
        };

        var buttonsPanel = new StackPanel
        {
            Orientation = Orientation.Horizontal,
            HorizontalAlignment = HorizontalAlignment.Center,
            Children = { yesButton, noButton }
        };

        var panel = new StackPanel
        {
            Margin = new Avalonia.Thickness(10),
            Children = { textBlock, buttonsPanel }
        };

        dialog.Content = panel;

        await dialog.ShowDialog(this);
        return result;
    }

    private async Task ShowInfoDialog(string title, string message)
    {
        var dialog = new Window
        {
            Title = title,
            Width = 350,
            Height = 160,
            WindowStartupLocation = WindowStartupLocation.CenterOwner,
            Background = Avalonia.Media.Brushes.White
        };

        var textBlock = new TextBlock
        {
            Text = message,
            Margin = new Avalonia.Thickness(10),
            Foreground = Avalonia.Media.Brushes.Black
        };

        var okButton = new Button
        {
            Content = "OK",
            Width = 80,
            HorizontalAlignment = HorizontalAlignment.Center,
            Margin = new Avalonia.Thickness(5)
        };

        okButton.Click += (_, _) => dialog.Close();

        var panel = new StackPanel
        {
            Margin = new Avalonia.Thickness(10),
            Children = { textBlock, okButton }
        };

        dialog.Content = panel;

        await dialog.ShowDialog(this);
    }
}