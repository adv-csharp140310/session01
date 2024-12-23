namespace session01;

/*
 Access Modifier
    https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    Public
    Internal
    
*/
public class Product 
{
    //fields
    private int _id;   
    
    //property
    public string Name { get; set; }
    public int Price { get; set; }
    public int Rate { get; set; }

    //Constractor
    public Product()
    {
        
    }
    public Product(string Name, int Price)
    {
        this.Name = Name;
        this.Price = Price; 
    }

    //method
    public int GetPrice()
    {
        return this.Price;
    }


    public void OverLoad()
    {

    }
    public void OverLoad(int a)
    {

    }

    public void OverLoad(string a)
    {

    }


    public void Calc(double a, double b, string op)
    {

    }


    //delegate/event
}
