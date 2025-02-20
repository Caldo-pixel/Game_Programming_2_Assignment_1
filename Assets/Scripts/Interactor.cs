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
                Signs signs = hitInfo.collider.gameObject.GetComponent<Signs>();
                signs.Interact();
                Debug.Log("Raycast hit: " + hitInfo.collider.name);
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
                if (hitInfo.collider.CompareTag("Sign"))
                {
                    Debug.Log("Good Job- The Sign grows and inch.");
                }

                else if (hitInfo.collider.CompareTag("Alligator"))
                {
                    Feed feed = hitInfo.collider.gameObject.GetComponent<Feed>();
                    feed.AnimalFood();
                    alli.Deathroll();
                }

                else if (hitInfo.collider.CompareTag("Meerkat"))
                {
                    Feed feed = hitInfo.collider.gameObject.GetComponent<Feed>();
                    feed.AnimalFood();
                    meerk.Stand();
                }

                else if (hitInfo.collider.CompareTag("Penguin"))
                {
                    Feed feed = hitInfo.collider.gameObject.GetComponent<Feed>();
                    feed.AnimalFood();
                    pengu.Slide();
                }

                else if (hitInfo.collider.CompareTag("Zebra"))
                {
                    Feed feed = hitInfo.collider.gameObject.GetComponent<Feed>();
                    feed.AnimalFood();
                    zebr.Hide();
                }
            }
            else
            {
                Debug.Log("You dropped your feed into the grass. Good job.");
            }
        }
    }
}