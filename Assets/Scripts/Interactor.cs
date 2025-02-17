using UnityEngine;

interface IInteractable
{
    void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    public LayerMask interactableLayer; 

    private Vector2 lastMoveDirection; // Stores the last movement direction

    void Update()
    {
        // Get player input for movement
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;

        // Update the last movement direction if the player is moving
        if (moveDirection != Vector2.zero)
        {
            lastMoveDirection = moveDirection;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // Cast a ray in the last movement direction
            RaycastHit2D hitInfo = Physics2D.Raycast(InteractorSource.position, lastMoveDirection, InteractRange, interactableLayer);

            if (hitInfo.collider != null)
            {
                Debug.Log("Raycast hit: " + hitInfo.collider.name);
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
            else
            {
                Debug.Log("Raycast did not hit anything.");
            }
        }
    }
}