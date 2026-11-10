using Codeops_Backend.Models;


// decimal calculateBonus(decimal salary, decimal rate, bool isManager)
// {
//     if (isManager)
//     {
//         return salary * rate * 2;
//     }
//     else
//     {
//         return salary * rate;
//     }
// }
MenuItem item1 = new MenuItem(1, "Burger", 5.99m, "Main Course");

List<MenuItem> menuItems = new List<MenuItem>
 {
     new MenuItem(1, "Burger", 5.99m, "Main Course"),
     new MenuItem(2, "Fries", 2.99m, "Side Dish"),
     new MenuItem(3, "Soda", 1.99m, "Beverage") ,
    new MenuItem(4, "Salad", 4.99m, "Appetizer"),
 };

 List <MenuItem> filteredItems = menuItems.Where(item => item.Category == "Main Course").ToList();

 foreach(var item in filteredItems)
 {
    Console.WriteLine($"Menu Item: {item.Name}, Price: {item.Price}");
    Console.WriteLine($"Price with VAT: {item.CalculatePriceWithVat()}");
 }

Console.WriteLine($"Menu Item: {item1.Name}, Price: {item1.Price}");
Console.WriteLine($"Price with VAT: {item1.CalculatePriceWithVat()}");


