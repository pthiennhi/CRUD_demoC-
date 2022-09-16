namespace ProductManager;

public class Program
{
    public static void Main(string[] args)
    {
        ProductList productList = new ProductList();
        int choice = -1;
        while (choice != 6)
        {
            PrintMenu();
            choice = Input.EnterInt("Your choice = ");
            switch (choice)
            {
                case 1:
                    productList.AddProducts();
                    break;
                case 2:
                    productList.Print();
                    break;
                case 3:
                    productList.GetProduct();
                    break;
                case 4:
                    productList.UpdateProduct();
                    break;
                case 5:
                    productList.DeleteProduct();
                    break;
            }
        }
    }

    // Requirement: Một sản phẩm gồm các thuộc tính 
    // - Mã sản phẩm
    // - Tên sản phẩm
    // - Giá niêm yết
    // - Ngày nhập về
    //     Viết 1 chương trình (OOP), thỏa mãn:
    // + Cho phép nhập n sản phẩm
    // + Cho phép in ra n sản phẩm => màn hình (Console)
    //     + Cho phép sửa/xóa/lấy ra 1 sản phẩm bất kỳ
    // */
    private static void PrintMenu()
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1: Import N Products");
        Console.WriteLine("2: Print Products");
        Console.WriteLine("3: Get Product");
        Console.WriteLine("4: Update Product");
        Console.WriteLine("5: Delete Product");
        Console.WriteLine("6: Exit");
    }
}