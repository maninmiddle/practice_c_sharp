using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _productName = string.Empty;
    private int _productQuantity;
    private decimal _productPrice;
    private string? _selectedCategory;
    private string? _selectedFilterCategory;
    private Product? _selectedProduct;

    public ObservableCollection<Product> Products { get; } = new();
    public ObservableCollection<Product> FilteredProducts { get; } = new();
    public ObservableCollection<string> Categories { get; } = new()
    {
        "Электроника",
        "Канцтовары",
        "Бытовая техника",
        "Продукты"
    };

    public string ProductName
    {
        get => _productName;
        set
        {
            _productName = value;
            OnPropertyChanged();
            UpdateCommands();
        }
    }

    public int ProductQuantity
    {
        get => _productQuantity;
        set
        {
            _productQuantity = value;
            OnPropertyChanged();
            UpdateCommands();
        }
    }

    public decimal ProductPrice
    {
        get => _productPrice;
        set
        {
            _productPrice = value;
            OnPropertyChanged();
            UpdateCommands();
        }
    }

    public string? SelectedCategory
    {
        get => _selectedCategory;
        set
        {
            _selectedCategory = value;
            OnPropertyChanged();
            UpdateCommands();
        }
    }

    public string? SelectedFilterCategory
    {
        get => _selectedFilterCategory;
        set
        {
            _selectedFilterCategory = value;
            OnPropertyChanged();
            ApplyFilter();
        }
    }

    public Product? SelectedProduct
    {
        get => _selectedProduct;
        set
        {
            _selectedProduct = value;
            OnPropertyChanged();

            if (value != null)
            {
                ProductName = value.Name;
                ProductQuantity = value.Quantity;
                ProductPrice = value.Price;
                SelectedCategory = value.Category;
            }

            UpdateCommands();
        }
    }

    public ICommand AddProductCommand { get; }
    public ICommand EditProductCommand { get; }
    public ICommand DeleteProductCommand { get; }

    public MainWindowViewModel()
    {
        Products.Add(new Product { Name = "Ноутбук", Quantity = 5, Price = 45000, Category = "Электроника" });
        Products.Add(new Product { Name = "Принтер", Quantity = 2, Price = 12000, Category = "Бытовая техника" });
        Products.Add(new Product { Name = "Тетрадь", Quantity = 50, Price = 80, Category = "Канцтовары" });
        Products.Add(new Product { Name = "Чай", Quantity = 30, Price = 150, Category = "Продукты" });

        AddProductCommand = new RelayCommand(_ => AddProduct(), _ => CanAddProduct());
        EditProductCommand = new RelayCommand(_ => EditProduct(), _ => CanEditProduct());
        DeleteProductCommand = new RelayCommand(_ => DeleteSelectedProduct(), _ => SelectedProduct != null);

        ApplyFilter();
    }

    private bool CanAddProduct()
    {
        return !string.IsNullOrWhiteSpace(ProductName)
               && ProductQuantity > 0
               && ProductPrice >= 0
               && !string.IsNullOrWhiteSpace(SelectedCategory);
    }

    private bool CanEditProduct()
    {
        return SelectedProduct != null
               && !string.IsNullOrWhiteSpace(ProductName)
               && ProductQuantity > 0
               && ProductPrice >= 0
               && !string.IsNullOrWhiteSpace(SelectedCategory);
    }

    public void AddProduct()
    {
        var product = new Product
        {
            Name = ProductName,
            Quantity = ProductQuantity,
            Price = ProductPrice,
            Category = SelectedCategory!
        };

        Products.Add(product);
        ApplyFilter();
        ClearInputFields();
    }

    public void EditProduct()
    {
        if (SelectedProduct == null)
            return;

        SelectedProduct.Name = ProductName;
        SelectedProduct.Quantity = ProductQuantity;
        SelectedProduct.Price = ProductPrice;
        SelectedProduct.Category = SelectedCategory!;

        ApplyFilter();
        OnPropertyChanged(nameof(SelectedProduct));
    }

    public void DeleteSelectedProduct()
    {
        if (SelectedProduct == null)
            return;

        Products.Remove(SelectedProduct);
        SelectedProduct = null;
        ApplyFilter();
        ClearInputFields();
    }

    public void ApplyFilter()
    {
        FilteredProducts.Clear();

        var filtered = string.IsNullOrWhiteSpace(SelectedFilterCategory)
            ? Products
            : new ObservableCollection<Product>(Products.Where(p => p.Category == SelectedFilterCategory));

        foreach (var product in filtered)
            FilteredProducts.Add(product);
    }

    private void ClearInputFields()
    {
        ProductName = string.Empty;
        ProductQuantity = 0;
        ProductPrice = 0;
        SelectedCategory = null;
    }

    private void UpdateCommands()
    {
        (AddProductCommand as RelayCommand)?.RaiseCanExecuteChanged();
        (EditProductCommand as RelayCommand)?.RaiseCanExecuteChanged();
        (DeleteProductCommand as RelayCommand)?.RaiseCanExecuteChanged();
    }
}