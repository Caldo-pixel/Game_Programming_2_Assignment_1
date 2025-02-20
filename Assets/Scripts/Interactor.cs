using UnityEngine;

interface IInteractable
{
    void Interact();
    
}

interface IFeed
{
    void AnimalFood();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    public LayerMask interactableLayer; 

    private Vector2 lastMoveDirection; // Stores the last movement direction

    Alligator alli = new Alligator();
    Meerkat meerk = new Meerkat();
    Zebra zebr = new Zebra();
    Penguin pengu = new Penguin();

    private void Start()
    {

    }
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

        if (Input.GetKeyDown(KeyCode.F))
        {
            RaycastHit2D hitInfo = Physics2D.Raycast(InteractorSource.position, lastMoveDirection, InteractRange, interactableLayer);

            if (hitInfo.collider != null)
            {
                Debug.Log("You have fed the " + hitInfo.collider.name);
                if (hitInfo.collider.CompareTag("Alligator"))
                {
                    if (hitInfo.collider.gameObject.TryGetComponent(out IFeed interactObj))
                    {
                        interactObj.AnimalFood();                        
                        alli.Deathroll();
                    }
                }

                else if (hitInfo.collider.CompareTag("Meerkat"))
                {
                    if (hitInfo.collider.gameObject.TryGetComponent(out IFeed interactObj))
                    {
                        interactObj.AnimalFood();
                        meerk.Stand();
                    }
                }

                else if (hitInfo.collider.CompareTag("Penguin"))
                {
                    if (hitInfo.collider.gameObject.TryGetComponent(out IFeed interactObj))
                    {
                        interactObj.AnimalFood();
                        pengu.Slide();
                    }
                }

                else if (hitInfo.collider.CompareTag("Zebra"))
                {
                    if (hitInfo.collider.gameObject.TryGetComponent(out IFeed interactObj))
                    {
                        interactObj.AnimalFood();
                        zebr.Hide();
                    }
                }
            }
            else
            {
                Debug.Log("You dropped your feed into the grass. Good job.");
            }
        }
    }
}