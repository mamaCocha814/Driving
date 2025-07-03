using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 50f;
    public float turnSpeed = 60f;
    private float horizontalInput;
    private float forwardInput;
   
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * 30 * Time.deltaTime * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
