using System;
namespace ECommercePlatform
{
    interface ITaxable
    {
        double CalculateTax();
        void GetTaxDetails();
    }
	public abstract class Product
	{
		private int productId;
		private string name;
		private int price;

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (value > 0) productId = value;
                else productId = 0;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value)) name = "";
                else name = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0) price = value;
                else price = 0;
            }
        }

        public abstract double CalculateDiscount();
		
	}

	public class Electronics : Product, ITaxable
	{
        public override double CalculateDiscount()
        {
            return Price * 0.12;
        }

        public double CalculateTax()
        {
            return Price * 0.10;
        }
        public void GetTaxDetails()
        {
            Console.WriteLine("Tax: 10%");
            Console.WriteLine("Price after adding tax:" + (Price + CalculateTax()));
        }
    }

    public class Clothing : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return Price * 0.5;
        }

        public double CalculateTax()
        {
            return Price * 0.20;
        }
        public void GetTaxDetails()
        {
            Console.WriteLine("Tax: 20%");
            Console.WriteLine("Price after adding tax:" + (Price + CalculateTax()));
        }
    }

    public class Groceries : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return Price * 0.1;
        }
        public double CalculateTax()
        {
            return Price * 0.18;
        }
        public void GetTaxDetails()
        {
            Console.WriteLine("Tax: 18%");
            Console.WriteLine("Price after adding tax:" + (Price + CalculateTax()));
        }
    }
}

