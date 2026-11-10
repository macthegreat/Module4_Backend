namespace Codeops_Backend.Models;

public class MenuItem
{
    public int Id {get; set;}
    public string Name {get; set;}
    public decimal Price {get; set;}
    public string Category {get; set;}

    public decimal ItemVat {get; private set;} = 0.15m;

     public MenuItem(int id, string name, decimal price, string category , decimal itemVat = 0.15m)
     {
         Id = id;
         Name = name;
         Price = price;
         Category = category;
         ItemVat = itemVat;
     }
     public decimal CalculatePriceWithVat()
     {
        if(Price < 0){

            throw new ArgumentException("Price cannot be negative.");
        }
         return Price + (Price * ItemVat);
     }

}