using JetBrains.Annotations;
using UnityEngine;

// TODO - Make this abstract
public abstract class Animal
{
    public int age;
    public float speed;
    public float weight;
    public float height;
    public float hunger;
    public float energy;
    public float excitment;
    public Color color;

    public abstract void Eat();

}

public class Alligator : Animal
{
    public float rotationalPower;

    public void Deathroll()
    {
        rotationalPower = 10f;
        Debug.Log("He Halth Rolled. His power holds a strength of " + rotationalPower);
    }

    public override void Eat()
    {
        hunger = 0.0f;
        energy = energy + 2;

        Debug.Log("RAAAAAAAAAAAAAH");
    }
}

public class Meerkat : Animal
{
    public float threatLevel;

    public void Stand()
    {
        threatLevel = threatLevel + 1;
        Debug.Log("Meerkat is staring into your soul.");
    }
    public override void Eat()
    {
        hunger = 0.0f;
        energy = energy + 2;

        Debug.Log("rEEEEEEEEEEEEEEEEEEEEE!");
    }
}

public class Zebra : Animal
{
    public float stealthLevel;

    public void Hide()
    {
        stealthLevel = stealthLevel + 3;
        Debug.Log("Zebra ran off and hid... Where'd he go?");
    }
    public override void Eat()
    {
        hunger = 0.0f;
        energy = energy + 2;

        Debug.Log("HUHN HUHN HUHN HUHN!");
    }
}

public class Penguin : Animal
{
    public float cutenessLevel;

    public void Slide()
    {
        cutenessLevel = 10;
        Debug.Log("Prepare to explode of cuteness.");
    }
    public override void Eat()
    {
        hunger = 0.0f;
        energy = energy + 2;

        Debug.Log("FLOP FLOP FLOP");
    }
}
