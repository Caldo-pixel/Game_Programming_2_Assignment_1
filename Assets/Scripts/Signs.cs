using UnityEngine;

public class Signs : MonoBehaviour, IInteractable
{
    private bool isReading = false;
    public GameObject signText;

    public void Interact()
    {
        isReading = true;
    }

    void Update()
    {
        if (isReading == true)
        {
            signText.SetActive(true);
        }
        else
        {
            signText.SetActive(false);
        }
    }

}
