using System.IO.Pipes;
using System.Text.RegularExpressions;

namespace FinalPrep
{
    class Product
    {
        private string? ProductName { get; set; }
        private decimal Price { get; set; }
        public List<string> StockQuantity { get; set; }

        public Product(string? productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
            StockQuantity = new List<string>();
        }

        public void ShowQuantity()
        {
            Console.WriteLine($"Total products: {StockQuantity.Count}");
            foreach (var stock in StockQuantity)
            {
                Console.WriteLine(stock);
            }

        }

        public void AddStock()
        {
            Console.WriteLine("Enter stock you wanna add: ");
            string? input = Console.ReadLine()?.Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                StockQuantity.Add(input);
                Console.WriteLine("Product added successfully");
            }
            else
                Console.WriteLine("Couldn't add the product");
        }

        public void RemoveStock()
        {
            bool flag = false;
            foreach (var stock in StockQuantity)
            {
                Console.WriteLine(stock);
            }
            while (!flag)
            {
                Console.WriteLine("Enter the stock you want to remove: ");
                string? input = Console.ReadLine()?.Trim();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    StockQuantity.Remove(input);
                    Console.WriteLine($"{input} removed successfully");
                    flag = true;
                }
                else
                    Console.WriteLine("Invalid input. Try again...");

                if (flag)
                    break;
                else
                    continue;
            }
        }

        public override string ToString()
        {
            return $"Product Name: {ProductName}, Price: {Price:C}, Stock Quantities: {string.Join(", ", StockQuantity)}";
        }
    }



    class Electronics : Product
    {
        private string? Brand;
        private int WarrantyPeriod;

        public Electronics(string? productName, decimal price, List<string> stockQuantity, string? brand, int warrantyPeriod)
            : base(productName, price)
        {
            this.Brand = brand;
            this.WarrantyPeriod = warrantyPeriod;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Brand: {Brand}, Warranty Period: {WarrantyPeriod} months";
        }

    }

    abstract class OrderItem
    {
        private string? Product;
        protected int Quantity;

        protected OrderItem(string? product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public abstract void CalculatePrice();
    }

    class ProductOrderItem : OrderItem
    {
        private decimal ProductPrice;

        public ProductOrderItem(string? product, int quantity, decimal productPrice)
            : base(product, quantity)
        {
            ProductPrice = productPrice;
        }

        public override void CalculatePrice()
        {
            decimal totalPrice = Quantity * ProductPrice;
            Console.WriteLine($"Total price for {Quantity} units of __ is: {totalPrice:C}");
        }
    }

    class ElectronicsOrderItem : OrderItem
    {
        private decimal ElectronicsPrice;

        public ElectronicsOrderItem(string? product, int quantity, decimal electronicsPrice)
            : base(product, quantity)
        {
            ElectronicsPrice = electronicsPrice;
        }

        public override void CalculatePrice()
        {
            decimal totalPrice = Quantity * ElectronicsPrice;
            Console.WriteLine($"Total price for {Quantity} units of __ is: {totalPrice:C}");
        }
    }


}