using UnityEngine;

public class Feed : MonoBehaviour, IInteractable
{
    private bool isFed = false;

    Alligator alligator = new Alligator();
    Meerkat meerkat = new Meerkat();
    Zebra zebra = new Zebra();
    Penguin penguin = new Penguin();

    public void InteractFed()
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

    public void Interact()
    {
        // Doesnt Do anything
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
        Debug.Log("Yummy!");
    }
    // Update is called once per frame

    private void Hungry()
    {
        isFed = false;
        Debug.Log("Im Hungry!");
    }
}
