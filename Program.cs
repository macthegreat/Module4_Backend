using Codeops_Backend.Models;


decimal calculateBonus(decimal salary, decimal rate, bool isManager){
    if(isManager){
        return salary * rate * 2;
    }else{
        return salary * rate;
    }
}
 MenuItem item1 = new MenuItem(1, "Burger", 5.99m, "Main Course");

 Console.WriteLine($"Menu Item: {item1.Name}, Price: {item1.Price}");
 Console.WriteLine($"Price with VAT: {item1.CalculatePriceWithVat()}");

Console.WriteLine(calculateBonus(20000m,0.15m,false));
Console.WriteLine(calculateBonus(20000m,0.15m,true));
