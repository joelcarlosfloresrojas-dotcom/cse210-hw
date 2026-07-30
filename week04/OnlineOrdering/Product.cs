class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string a, int b ,double c ,int d)
    {
        _name=a;
        _id=b;
        _price=c;
        _quantity=d;
    }

    public string GetProduct(){
        return $"Product: {_name} (ID: {_id})\n" +
                $"Price: ${_price}\n" +
                $"Quantity: {_quantity}"; 
    }

    
    public double GetTotal()
    {
      return  _price*_quantity;   
    }

}