namespace ProductManager;

public class Product
{
    public string Code { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime ImportDate { get; set; }


    public override string ToString()
    {
        return $"{Code} {Name} {Price} {ImportDate}";
    }

    
}