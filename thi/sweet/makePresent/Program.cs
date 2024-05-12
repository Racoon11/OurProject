using sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace makePresent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NYPresent present = PresentFactory.CreatePresent();
            PresentPrinter.PrintWeight(present.getWeight());
            int weight = Counter.CountWeight(present);
            PresentPrinter.PrintWeightWithout(weight);
            int calories = Counter.CountCalories(present);
            PresentPrinter.PrintCalories(calories);

        }
    }
}

public class PresentPrinter
{
    public static void PrintWeight(int present)
    {
        Console.Write("Вес подарка = ");
        Console.WriteLine(present);
    }
    public static void PrintWeightWithout(int numb)
    {
        Console.Write("Вес подарка без упаковки = ");
        Console.WriteLine(numb);
    }
    public static void PrintCalories(int numb)
    {
        Console.Write("Калорийность = ");
        Console.WriteLine(numb);
    }
}

public class Counter
{
    public static int CountWeight(NYPresent present)
    {
        int ans = 0;
        for (int i=0; i<present.GetNumber(); i++)
        {
            ans += present.GetSweet(i).GetWeight();
        }
        return ans;
    }
    public static int CountCalories(NYPresent present)
    {
        int ans = 0;
        for (int i = 0; i < present.GetNumber(); i++)
        {
            ans += present.GetSweet(i).GetCalories();
        }
        return ans;
    }
}
public class PresentFactory
{
    public static NYPresent CreatePresent()
    {
        NYPresent present = new NYPresent("Yashkino", "paper", 40);
        Wrapping uniWrap = new Wrapping("Yashkino", "flowpack", 2);
        Filling milkFill = new Filling(12, 40, 10, "milk");
        Filling chockFill = new Filling(12, 50, 10, "chockolate filling");
        Candy candyWithChockFill = new Candy(50, 60, 15, chockFill);
        Candy candy = new Candy(30, 10, 10);
        Candy candy2 = new Candy(50, 30, 20);
        Chocolate chock = new Chocolate(500, 1200, 100, "milk chocolate");
        WaffleCandy waff = new WaffleCandy(600, 600, 200, "lemon", milkFill, chock);

        List<Sweet> sweets = new List<Sweet>() { candy, candy2, candyWithChockFill, chock, waff, chock };
        foreach (Sweet sweet in sweets)
        {
            WrappedSweet ws = new WrappedSweet(uniWrap, sweet);
            present.addCandy(ws);
        }
        return present;
    }
    public static WrappedSweet makeWrappedSweet(Sweet sweet)
    {
        Wrapping uniWrap = new Wrapping("Yashkino", "flowpack", 2);
        return new WrappedSweet(uniWrap, sweet);
    }
}
