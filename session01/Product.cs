namespace session01;

class Product 
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Rate { get; set; }

    public Product()
    {
        
    }
    public Product(string Name, int Price)
    {
        this.Name = Name;
        this.Price = Price; 
    }
}
