using UnityEngine;

public class Feed : MonoBehaviour, IFeed
{
    private bool isFed = false;

    Alligator alligator = new Alligator();
    Meerkat meerkat = new Meerkat();
    Zebra zebra = new Zebra();
    Penguin penguin = new Penguin();

    public void AnimalFood()
    {
        if (isFed)
        {
            Hungry();
        }
        else
        {
            Fed();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        alligator.hunger = 0;
        meerkat.hunger = 0;
        zebra.hunger = 0;
        penguin.hunger = 5;

        
    }

    private void Fed()
    {
        isFed = true;
        alligator.Eat();
        Debug.Log("YUM!");
    }
    // Update is called once per frame

    private void Hungry()
    {
        isFed = false;
        Debug.Log("Im Hungry!");
    }
}
