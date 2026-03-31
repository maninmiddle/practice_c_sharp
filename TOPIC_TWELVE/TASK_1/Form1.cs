namespace TASK_1;

public partial class Form1 : Form
{
    private BindingList<Product> productsList = new BindingList<Product>();
    private int nextProductId = 1;

    public Form1()
    {
        InitializeComponent();
        Load += Form1_Load;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SetupDataGridView();
        LoadProducts();
        productsDataGridView.DataSource = productsList;

        addToolStripButton.Click += AddToolStripButton_Click;
        editToolStripButton.Click += EditToolStripButton_Click;
        deleteToolStripButton.Click += DeleteToolStripButton_Click;
    }

    private void SetupDataGridView()
    {
        productsDataGridView.AutoGenerateColumns = false;
        productsDataGridView.Columns.Clear();

        productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", ReadOnly = true });
        productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name", HeaderText = "Название", DataPropertyName = "Name" });
        productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Description", HeaderText = "Описание", DataPropertyName = "Description" });
        productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Price", HeaderText = "Цена", DataPropertyName = "Price", DefaultCellStyle = { Format = "N2" } });
        productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Quantity", HeaderText = "Количество", DataPropertyName = "Quantity" });

        productsDataGridView.AllowUserToAddRows = false;
        productsDataGridView.AllowUserToDeleteRows = false;
        productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        productsDataGridView.ReadOnly = true;

        productsDataGridView.CellDoubleClick += ProductsDataGridView_CellDoubleClick;
    }

    private void LoadProducts()
    {
        productsList.Add(new Product { Id = nextProductId++, Name = "Ноутбук", Description = "Мощный игровой ноутбук", Price = 1200.50m, Quantity = 5 });
        productsList.Add(new Product { Id = nextProductId++, Name = "Мышь", Description = "Беспроводная оптическая мышь", Price = 25.00m, Quantity = 20 });
        productsList.Add(new Product { Id = nextProductId++, Name = "Клавиатура", Description = "Механическая клавиатура с подсветкой", Price = 75.99m, Quantity = 10 });
    }

    private void AddToolStripButton_Click(object sender, EventArgs e)
    {
        AddNewProduct();
    }

    private void EditToolStripButton_Click(object sender, EventArgs e)
    {
        EditSelectedProduct();
    }

    private void DeleteToolStripButton_Click(object sender, EventArgs e)
    {
        DeleteSelectedProduct();
    }

    private void AddNewProduct()
    {
        using (ProductEditForm editForm = new ProductEditForm())
        {
            editForm.Product = new Product();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                Product newProduct = editForm.Product;
                newProduct.Id = nextProductId++;
                productsList.Add(newProduct);
            }
        }
    }

    private void EditSelectedProduct()
    {
        if (productsDataGridView.SelectedRows.Count > 0)
        {
            Product selectedProduct = productsDataGridView.SelectedRows[0].DataBoundItem as Product;
            if (selectedProduct != null)
            {
                using (ProductEditForm editForm = new ProductEditForm())
                {
                    editForm.Product = selectedProduct;
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Изменения уже в selectedProduct
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите товар для редактирования.");
        }
    }

    private void DeleteSelectedProduct()
    {
        if (productsDataGridView.SelectedRows.Count > 0)
        {
            var selectedRow = productsDataGridView.SelectedRows[0];
            Product productToDelete = selectedRow.DataBoundItem as Product;
            if (productToDelete != null)
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить товар '{productToDelete.Name}'?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productsList.Remove(productToDelete);
                }
            }
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите товар для удаления.");
        }
    }

    private void ProductsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            EditSelectedProduct();
        }
    }
}
