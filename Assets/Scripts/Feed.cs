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
        Fed();
    }

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
        if (CompareTag("Alligator"))
        {
            alligator.Eat();
        }

        if (CompareTag("Meerkat"))
        {
            meerkat.Eat();
        }

        if (CompareTag("Zebra"))
        {
            zebra.Eat();
        }

        if (CompareTag("Penguin"))
        {
            penguin.Eat();
        }
    }
}
