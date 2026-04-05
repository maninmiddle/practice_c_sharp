using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private Product? _selectedProduct;

    public ObservableCollection<Product> Products { get; } = new();

    public Product? SelectedProduct
    {
        get => _selectedProduct;
        set
        {
            _selectedProduct = value;
            OnPropertyChanged();
        }
    }

    public MainWindowViewModel()
    {
        Products.Add(new Product { Name = "Ноутбук", Quantity = 5, Price = 45000 });
        Products.Add(new Product { Name = "Мышь", Quantity = 20, Price = 1200 });
        Products.Add(new Product { Name = "Клавиатура", Quantity = 10, Price = 2500 });
    }

    public void AddProduct()
    {
        Products.Add(new Product
        {
            Name = "Новый товар",
            Quantity = 1,
            Price = 1000
        });
    }

    public void EditProduct()
    {
        if (SelectedProduct == null)
            return;

        SelectedProduct.Name += " (ред.)";

        // Обновление списка
        var index = Products.IndexOf(SelectedProduct);
        if (index >= 0)
        {
            Products[index] = new Product
            {
                Name = SelectedProduct.Name,
                Quantity = SelectedProduct.Quantity,
                Price = SelectedProduct.Price
            };
            SelectedProduct = Products[index];
        }
    }

    public void DeleteSelectedProduct()
    {
        if (SelectedProduct == null)
            return;

        Products.Remove(SelectedProduct);
        SelectedProduct = null;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}