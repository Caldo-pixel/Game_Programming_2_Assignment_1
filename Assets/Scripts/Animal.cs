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
    public float stealthLevel;

    public void Swim()
    {

    }
}

public class Meerkat : Animal
{
    public void Stand()
    {

    }
}

public class Zebra : Animal
{
    
}

public class Penguin : Animal
{
    public float cutenessLevel;

    public void Slide()
    {

    }
}
