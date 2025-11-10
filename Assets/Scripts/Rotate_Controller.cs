using UnityEngine;

public class Rotate_Controller : MonoBehaviour
{
   // This variable is used for attaching the game object
   public GameObject planetObject;
   public Vector3 RotationVector;

    // Update is called once per frame
    void Update()
    {
        planetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}
