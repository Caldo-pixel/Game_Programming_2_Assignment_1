using UnityEngine;

public class test : MonoBehaviour, IInteractable
{
   public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
    }
}
