using task2_crud.Data;
using task2_crud.Models;

namespace task2_crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            //create
            
            Product p= new Product() { Name="ali",Price=2000 };
            dbContext.Products.Add(p);
            Order o = new Order() {  Address = "Nablus",CreateAt=new DateTime(2024,8,9,22,40,27,210) };
            dbContext.Orders.Add(o);
            //read
            var products = dbContext.Products.ToList();
            foreach(var product in products)
            {
                Console.WriteLine(product.Name);
            }
            var orders = dbContext.Orders.ToList();
            foreach (var order in orders)
            {
                Console.WriteLine(order.Address);
            }
            //update
            var pro = dbContext.Products.First(p => p.Id == 3);
            pro.Name = "Tariq";
           
            var ord = dbContext.Orders.First(o => o.Id == 1);
            ord.CreateAt = new DateTime(2024, 8, 17, 23, 12, 10, 210);
            
            //remove
           var prod = dbContext.Products.First(p => p.Id == 2);
           dbContext.Products.Remove(prod);

           var ore = dbContext.Orders.First(ord => ord.Id == 3);
           dbContext.Orders.Remove(ore);

           
            dbContext.SaveChanges();
          
           
            Console.WriteLine("done");

        }
    }
}