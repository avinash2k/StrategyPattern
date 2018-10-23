using System;

//WildDuck , CityDuck classes are no longer needed
class Duck
{
    WalkBehaviour walkBehaviour;
    FlyBehaviour flyBehaviour;
    string name;

    //this is also called constructor injection
    public Duck(string duckName, WalkBehaviour wb, FlyBehaviour fb)
    {
        name = duckName;
        walkBehaviour = wb;
        flyBehaviour = fb;
    }

    public string Name()
    {
        return name;
    }

    public string Fly()
    {
        return this.flyBehaviour.Fly();
    }

    public string Walk()
    {
        return this.walkBehaviour.Walk();
    }
}


/// <summary>
/// Walking Algorithms for Ducks.
/// </summary>

interface WalkBehaviour
{
    string Walk();
}

class WalkBehaviourF : WalkBehaviour
{
    public string Walk()
    {
        return "Walking-F";
    }
}

class WalkBehaviourD : WalkBehaviour
{
    public string Walk()
    {
        return "Walking-D";
    }
}

/// <summary>
/// Flight Algorithms for Ducks.
/// </summary>
interface FlyBehaviour
{
    string Fly();
}

class FlyBehaviourA : FlyBehaviour
{
    public string Fly()
    {
        return "Flying-A";
    }
}

class FlyBehaviourB : FlyBehaviour
{
    public string Fly()
    {
        return "Flying-B";
    }
}

class StrategyPattern
{
    static void Main(string[] args)
    {
        //Ducks with different behaviours can be created at runtime 
        //and make use of different ways to walk and fly !
        Duck wildDuck = new Duck("Wild Duck", new WalkBehaviourD(), new FlyBehaviourA());
        Console.WriteLine(wildDuck.Name() + " walks like " + wildDuck.Walk());

        Duck mountainDuck = new Duck("Mountain Duck", new WalkBehaviourD(), new FlyBehaviourB());
        Console.WriteLine(mountainDuck.Name() + " flies like " + mountainDuck.Fly());

        Duck cloudDuck = new Duck("Cloud Duck", new WalkBehaviourF(), new FlyBehaviourB());
        Console.WriteLine(cloudDuck.Name() + " walks like " + cloudDuck.Walk() + " flies like " + cloudDuck.Fly());
    }
}

// Output :
//Wild Duck walks like Walking-D
//Mountain Duck flies like Flying-B
//Cloud Duck walks like Walking-F flies like Flying-B

