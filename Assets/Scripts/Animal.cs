using JetBrains.Annotations;
using UnityEngine;

public class Animal
{
    public int age;
    public float speed;
    public float weight;
    public float height;
    public float hunger;
    public float energy;
    public float excitment;
    public Color color;

    public void Eat()
    {
        hunger = 0.0f;
        energy = energy + 2;
    }

    public void Play()
    {
        energy = energy - 2;
        hunger = hunger + 2;
    }

    public void Joy()
    {
        excitment = excitment + 2;
        energy = energy + 1;
    }

    public void Sleep()
    {
        energy = 10;
    }
}

public class Alligator : Animal
{
    public float rotationalPower;

    public void Deathroll()
    {
        rotationalPower = 10f;
        Debug.Log("He Halth Rolled.");
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
}

public class Zebra : Animal
{
    public float stealthLevel;

    public void Hide()
    {
        stealthLevel = stealthLevel + 3;
        Debug.Log("Zebra is hiding... Where'd he go?");
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
}
