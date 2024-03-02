using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Rotate the object only around the Z axis by a specified amount, adjusted for frame rate.
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
