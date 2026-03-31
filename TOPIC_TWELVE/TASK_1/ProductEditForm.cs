using System;

public partial class ProductEditForm : Form
{
    public Product Product { get; set; }

    public ProductEditForm()
    {
        InitializeComponent();
    }

    private void ProductEditForm_Load(object sender, EventArgs e)
    {
        if (Product != null && Product.Id != 0)
        {
            this.Text = "Редактирование товара";
            idTextBox.Text = Product.Id.ToString();
            nameTextBox.Text = Product.Name;
            descriptionTextBox.Text = Product.Description;
            priceTextBox.Text = Product.Price.ToString("F2");
            quantityTextBox.Text = Product.Quantity.ToString();
        }
        else
        {
            this.Text = "Добавление нового товара";
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nameTextBox.Text))
        {
            MessageBox.Show("Название товара не может быть пустым.");
            return;
        }

        if (!decimal.TryParse(priceTextBox.Text, out decimal price) || price < 0)
        {
            MessageBox.Show("Некорректная цена.");
            return;
        }

        if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity < 0)
        {
            MessageBox.Show("Некорректное количество.");
            return;
        }

        if (Product == null)
        {
            Product = new Product();
        }

        Product.Name = nameTextBox.Text;
        Product.Description = descriptionTextBox.Text;
        Product.Price = price;
        Product.Quantity = quantity;

        DialogResult = DialogResult.OK;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }
}

