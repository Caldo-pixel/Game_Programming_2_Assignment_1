using UnityEngine;

public class InteractablePrompt : MonoBehaviour
{
    public GameObject promptUI;
    public Transform player; 
    public float interactionRange = 2f; 

    void Update()
    {
        
        if (Vector2.Distance(transform.position, player.position) <= interactionRange)
        {
            promptUI.SetActive(true); 
        }
        else
        {
            promptUI.SetActive(false); 
        }
    }
}
