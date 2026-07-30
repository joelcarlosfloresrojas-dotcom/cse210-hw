using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Order
{
    private List<Product> _products=new List<Product>();
    private Customer _customer;
    

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double DisplayTotal()
    {
        double helper=0;
        for(int i = 0;i<_products.Count;i++)
        {
            helper +=_products[i].GetTotal();
            
        }
          
        if (_customer.GetUSA() == true)
        {
            helper=helper+5;

            return helper;
        }
        else
        {
            helper=helper+35;
             return helper;
        }
              

    }

    public string GetPacking()
    {
       string packingLabel = "";
    
        for(int i = 0; i < _products.Count; i++)
        {
            
            packingLabel += _products[i].GetProduct() + "\n\n";
        }
        return packingLabel;
    }
    

    public string GetDisplayShipping()
    {
       
      return   $"Name: {_customer.GetName()}\n" +
               $"{_customer.GetAddress()}";


    }
}