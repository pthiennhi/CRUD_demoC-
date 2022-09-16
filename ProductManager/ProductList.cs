namespace ProductManager;

public class ProductList
{
    private readonly List<Product> _products = new List<Product>();


    public void Print()
    {
        Console.WriteLine("Product List: ");
        foreach (var product in _products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void AddProducts()
    {
        int n = Input.EnterInt("N = ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Product " + (i + 1) + ": ");

            string code;
            do
            {
                code = Input.EnterString("Code = ");
                if (Get(code) != null)
                {
                    Console.WriteLine("Duplicate code");
                }
            } while (Get(code) != null);

            string name = Input.EnterString("Name = ");
            double price = Input.EnterDouble("Price = ");
            DateTime importDate = Input.EnterDate("ImportDate = ", "dd/MM/yyyy");

            Product product = new Product()
            {
                Code = code,
                Name = name,
                Price = price,
                ImportDate = importDate
            };
            Add(product);
        }
    }

    public void GetProduct()
    {
        string code = Input.EnterString("Code = ");
        var product = Get(code);
        if (product == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void UpdateProduct()
    {
        string code = Input.EnterString("Code = ");
        var product = Get(code);
        if (product == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            string name = Input.EnterString("Name = ");
            double price = Input.EnterDouble("Price = ");
            DateTime importDate = Input.EnterDate("ImportDate = ", "dd/MM/yyyy");

            product = new Product
            {
                Code = code,
                Name = name,
                Price = price,
                ImportDate = importDate
            };
            Update(product);
        }
    }

    public void DeleteProduct()
    {
        string code = Input.EnterString("Code = ");
        var product = Get(code);
        if (product == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            Delete(code);
        }
    }

    public Product Get(String code)
    {
        foreach (var product in _products)
        {
            if (product.Code == code)
            {
                return product;
            }
        }

        return null;
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Update(Product product)
    {
        for (var i = 0; i < _products.Count; i++)
        {
            if (_products[i].Code == product.Code)
            {
                _products[i] = product;
            }
        }
    }

    public void Delete(String code)
    {
        for (var i = 0; i < _products.Count; i++)
        {
            if (_products[i].Code == code)
            {
                _products.RemoveAt(i);
                break;
            }
        }
    }
}