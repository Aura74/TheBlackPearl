using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearl
{
    internal class Pearl : IPearl
    {
        public const int basePrice = 50;
        public int Diameter { get; set; }
        public string Color { get; set; } // kan vara Enum om man vill
        public string Shape { get; set; }
        public string Type { get; set; }
        
        private int price;
        public int Price
        {
            get 
            {
                if (Type == "Saltvatten")
                {
                    return basePrice * Diameter * 2;
                }
                else
                {
                    return basePrice * Diameter;
                }
            }
            set { price = value; }
        }

        //Skriv i fler här  funkar inte utan, 
        public int CompareTo(IPearl other)
        {
            // om level inte är sorterad redan så sorteras den nu efter level, och sedan efternamn, är level redan sorterat så hoppar den direkt till efternamn
            if (Diameter != other.Diameter)
            {
                return Diameter.CompareTo(other.Diameter);
            }
            if (Color != other.Color)
            {
                return Color.CompareTo(other.Color);
            }
            else
            {
                return Shape.CompareTo(other.Shape);
            }
        }
        
        //Skriv i fler här,  funkar inte utan
        public bool Equals(IPearl other)
        {
            return (Color) == (other.Color);
        }

       // public bool Equals(IPearl other) => (this.Size, this.Color, this.Shape, this.Type) == (other.Size, other.Color, other.Shape, other.Type);
        //public override bool Equals(object obj) => Equals(obj as IPearl);
        //public override int GetHashCode() => (Size, Color, Shape, Type).GetHashCode();

        // Legacy .NET compliance ska va med om man använder Equals
        public override bool Equals(object obj) => Equals(obj as IPearl);
        public override int GetHashCode() => (Color, Shape).GetHashCode();

        // Skriver ut Member, måste vara med
        public override string ToString()
        {
            return $"Färg: {Color}, Formen: {Shape}, VattenTyp: {Type}, Diameter: {Diameter}mm och priset för pärlan är: { Price}sKr";
        }
        
        // Här skapas slumpmässig pärla
        public void RandomInit()
        {
                var rnd = new Random();
                while (true)
                {
                    try
                    {
                    string[] _color = "Svart Vit Rosa".Split(' ');
                    this.Color = _color[rnd.Next(0, _color.Length)];

                    string[] _shape = "Rund Droppformad".Split(' ');
                    this.Shape = _shape[rnd.Next(0, _shape.Length)];

                    string[] _type = "Sötvatten Saltvatten".Split(' ');
                    this.Type = _type[rnd.Next(0, _type.Length)];

                    int _size = rnd.Next(5, 26);
                    this.Diameter = _size;

                    return;
                }
                    catch { }
                }
        }

        //Utan den blev det inget til color osv
        public Pearl()
        {
            RandomInit();
        }

        // Factory
        public static class Factory
        {
            public static Pearl CreateRandomPearl()
            {
                var p = new Pearl();
                p.RandomInit();
                return p;
            }
        }
    }
}
