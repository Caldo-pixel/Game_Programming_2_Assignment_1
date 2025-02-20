using UnityEngine;

public class RotateTest : MonoBehaviour
{
    float time = 0.0f;
    Vector3 initialPosition = Vector3.zero;


    void Start()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        time += Time.deltaTime;
        transform.RotateAround(initialPosition, Vector3.forward, time * 50.0f);
    }
}
