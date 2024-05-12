using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sweets
{
    public class Sweet
    {
        private int _calories;
        private int _joy;
        private int _weight;

        public Sweet(int calories, int joy, int weight)
        {
            _calories = calories;
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
        virtual public int GetCalories()
        {
            return _calories;
        }
        public void SetCalories(int value)
        {
            _calories = value;
        }

        virtual public string GetName()
        {
            return "name";
        }
        public int Joy { get { return _joy; } set { _joy = value; } }

        virtual public int CountCalories() { return _calories * _weight; }

    }
    public class Filling : Sweet
    {
        private string _type = "";
        public Filling(int calories, int joy, int weight, string type) :
            base(calories, joy, weight)
        {
            _type = type;
        }
        public override string GetName()
        {
            return _type;
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
            if (_filling != null) return _filling.GetWeight() + base.GetWeight();
            return base.GetWeight();
        }
        public override int GetCalories()
        {
            if (_filling != null) return _filling.GetCalories() + base.GetCalories();
            return base.GetCalories();
        }
        public override string GetName()
        {
            string st = "Candy";
            if (_filling  == null) return st;
            st += " with " + _filling.GetName();
            return st;
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
        public override string GetName()
        {
            return "Chocolate";
        }
    }

    public class ChocolateCandy : Candy
    {
        private Chocolate _chocolate;

        public ChocolateCandy(int calories, int joy, int weight, Filling fill, Chocolate chocolate) :
            base(calories, joy, weight, fill)
        {
            _chocolate = chocolate;
        }
        public override int GetWeight()
        {
            return _chocolate.GetWeight() + base.GetWeight();
        }
        public override int GetCalories()
        {
            return base.GetCalories() + _chocolate.GetCalories();
        }
        public override string GetName()
        {
            return "Chocolate Candy";
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
        public override int GetCalories()
        {
            return base.GetCalories() + _filling.GetCalories();
        }
        public override string GetName()
        {
            return "Waffle";
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
        public override int GetCalories()
        {
            return base.GetCalories() + _chocolate.GetCalories();
        }
        public override string GetName()
        {
            return "Waffle Candy";
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

        public int GetWeight()
        {
            return _weight;
        }
        public int GetCalories()
        {
            return _sweet.GetCalories();
        }
        public string GetName()
        {
            return _sweet.GetName();
        }
    }

    public class NYPresent : Wrapping
    {
        private List<WrappedSweet> _sweets;

        public NYPresent(string firm, string material, int weight,
            List<WrappedSweet> sweets) :
            base(firm, material, weight)
        {
            _sweets = sweets;
            foreach (WrappedSweet sweet in _sweets)
            {
                _weight += sweet.GetWeight();
            }
        }
        public NYPresent(string firm, string material, int weight) :
            base(firm, material, weight)
        {
            _sweets = new List<WrappedSweet>();
        }

        public override int getWeight()
        {
            return _weight;
        }

        public void addCandy(WrappedSweet sweet)
        {
            _sweets.Add(sweet);
            _weight += sweet.GetWeight();
        }
        public WrappedSweet GetSweet(int i)
        {
            if (GetNumber() <= i)
            {
                return null;
            }
            return _sweets[i];
        }
        public void SetSweet(int i, WrappedSweet sweet)
        {
            _sweets[i] = sweet;
        }
        public void DeleteSweet(int i)
        {
            _sweets.RemoveAt(i);
        }
        public int GetNumber()
        {
            return _sweets.Count;
        }
    }
}
