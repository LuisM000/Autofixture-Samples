using System;
namespace AutofixtureSamples
{
    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public bool IsExpensive()
        {
            return this.Cost > 999;
        }
    }
}
