using System;

//ref link:https://www.youtube.com/watch?v=3wRhVZUeUKo&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=2
//

//class PairIntInt
//class Pair<T, U>
class Pair<T>
{
    //public int First { get; set; }
    public T First { get; set; }
    //public int Second { get; set; }
    //public U Second { get; set; }
    public T Second { get; set; }
    public override string ToString()
    {
        return "{ " + First + ", " + Second + "}";
    }
}


class MainClass
{
    static void Main()
    {
        //PairIntInt p = new PairIntInt { First = 5, Second = 20 };
        //Pair<int, int> p = new Pair<int, int> { First = 5, Second = 20 };
        Pair<int> p = new Pair<int> { First = 5, Second = 20 };

        //PairStringString marriage1 = new PairStringString { First = "Suzy", Second = "Bob" };
        //PairStringString marriage2 = new PairStringString { First = "Fred", Second = "Bill" };
        //PairStringString marriage3 = new PairStringString { First = "Samantha", Second = "Rover" };
        //Pair<string, string> marriage1 = new Pair<String, String> { First = "Suzy", Second = "Bob" };
        //Pair<string, string> marriage2 = new Pair<String, string> { First = "Fred", Second = "Bill" };
        //Pair<string, float> marriage2 = new Pair<String, float> { First = "Fred", Second = 900.0f };
        //Pair<string, string> marriage3 = new Pair<String, String> { First = "Samantha", Second = "Rover" };
        Pair<string> marriage1 = new Pair<String> { First = "Suzy", Second = "Bob" };
        Pair<string> marriage2 = new Pair<String> { First = "Fred", Second = "Bill" };
        Pair<string> marriage3 = new Pair<String> { First = "Samantha", Second = "Rover" };

        //Console.WriteLine(marriage1.ToString());
        //Console.WriteLine(marriage1.GetType().Equals(p.GetType()));
        Console.WriteLine(p.GetType());
        Console.WriteLine(marriage1.GetType());

    }
}