using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweet
{
    public class Sweet
    {
        private int _calories;
        private int _joy;
        private int _weight;

        public Sweet(int calories, int joy, int weight)
        {
            Calories = calories;
            Joy = joy;
            _weight = weight;
        }

        virtual public int GetWeight()
        {
            return _weight;
        }
        public void SetWeight(int value)
        {
            _weight = value;
        }
        public int Calories { get { return _calories; } set { _calories = value; } }
        public int Joy { get { return _joy; } set { _joy = value; } }

        virtual public int CountCalories() { return _calories * _weight; }

    }
    public class Filling : Sweet
    {
        private string _type;
        public Filling(int calories, int joy, int weight, string type) :
            base(calories, joy, weight)
        {
            _type = type;
        }
        public string Type { get { return _type; } set { _type = value; } }

    }
    public class Candy : Sweet
    {
        private Filling _filling;
        public Candy(int calories, int joy, int weight, Filling filling = null) :
            base(calories, joy, weight)
        {
            _filling = filling;
        }
        public override int GetWeight()
        {
            return _filling.GetWeight() + base.GetWeight();
        }
    }

    public class Chocolate : Sweet
    {
        private string _type;
        public Chocolate(int calories, int joy, int weight, string type) :
            base(calories, joy, weight)
        {
            _type = type;
        }
    }

    public class ChocolateCandy : Sweet
    {
        private Chocolate _chocolate;

        public ChocolateCandy(int calories, int joy, int weight, Chocolate chocolate) :
            base(calories, joy, weight)
        {
            _chocolate = chocolate;
        }
        public override int GetWeight()
        {
            return _chocolate.GetWeight() + base.GetWeight();
        }
    }

    public class Waffle : Sweet
    {
        private string _taste;
        private Filling _filling;

        public Waffle(int calories, int joy, int weight,
            string taste, Filling filling) :
        base(calories, joy, weight)
        {
            _taste = taste;
            _filling = filling;
        }
        public override int GetWeight()
        {
            return _filling.GetWeight() + base.GetWeight();
        }
    }
    public class WaffleCandy : Waffle
    {
        private Chocolate _chocolate;

        public WaffleCandy(int calories, int joy, int weight,
            string taste, Filling filling, Chocolate choc) :
            base(calories, joy, weight, taste, filling)
        {
            _chocolate = choc;
        }

        public override int GetWeight()
        {
            return base.GetWeight() + _chocolate.GetWeight();
        }
    }

    public class Wrapping
    {
        private string _firm;
        private string _material;
        protected int _weight;

        public Wrapping(string firm, string material, int weight)
        {
            _firm = firm;
            _material = material;
            _weight = weight;
        }
        virtual public int getWeight()
        {
            return _weight;
        }
    }

    public class WrappedSweet
    {
        private Wrapping _wrap;
        private Sweet _sweet;
        private int _weight;

        public WrappedSweet(Wrapping wrap, Sweet sweet)
        {
            _wrap = wrap;
            _sweet = sweet;
            _weight = _wrap.getWeight() + _sweet.GetWeight();
        }

        public int getWeight()
        {
            return _weight;
        }
    }

    public class NYPresent : Wrapping
    {
        private List<Sweet> _sweets;

        public NYPresent(string firm, string material, int weight,
            List<Sweet> sweets) :
            base(firm, material, weight)
        {
            _sweets = sweets;
            foreach (Sweet sweet in _sweets)
            {
                _weight += sweet.GetWeight();
            }
        }

        public override int getWeight()
        {
            return _weight;
        }
    }

}
