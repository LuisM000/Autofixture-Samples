using System;
namespace AutofixtureSamples
{
    public class Country
	{
		public string Name { get; }

        public Country(string name)//Si esto se hubiese llamado Name, mi SpanishUserCustomization fallaría, pues utilizaría en name de 
        {
            this.Name = name;
        }
    }
}
