using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    private bool isOpen = false; // Tracks whether the door is open or closed

    public void Interact()
    {
        if (isOpen)
        {
            CloseDoor();
        }
        else
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        Debug.Log("Door is now open!");
        isOpen = true;

        // Add your door-opening logic here
        // For example, rotate the door or move it out of the way
        transform.Rotate(0, 0, -90); // Rotate the door 90 degrees to "open" it
    }

    private void CloseDoor()
    {
        Debug.Log("Door is now closed!");
        isOpen = false;

        // Add your door-closing logic here
        // For example, rotate the door back to its original position
        transform.Rotate(0, 0, 90); // Rotate the door back to its original position
    }
}