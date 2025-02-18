using UnityEngine;

public class Animal
{
    public int age;
    public float speed;
    public float weight;
    public float height;
    public float hunger;
    public float energy;
    public Color color;

    public void Eat()
    {
        hunger = 0.0f;
    }

    public void Exercise()
    {

    }

    public void Sleep()
    {

    }
}

public class Alligator : Animal
{
    public float rotationalPower;

    public void Deathroll()
    {

    }
}

public class Meerkat : Animal
{
    public float threatLevel;

    public void Stand()
    {

    }
}

public class Zebra : Animal
{
    public float stealthLevel;

    public void Hide()
    {

    }
}

public class Penguin : Animal
{
    public float cutenessLevel;

    public void Slide()
    {

    }
}
