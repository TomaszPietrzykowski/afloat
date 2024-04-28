using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensitivityX; // external tunning
    public float sensitivityY; // external tunning
    private float sensitivityFactor = 0.05f; // internal tunning

    public Transform orientation;

    float rotationX;
    float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * sensitivityX * sensitivityFactor;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivityY * sensitivityFactor;

        rotationY += mouseX;
        rotationX -= mouseY; //...whooot?
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        orientation.rotation = Quaternion.Euler(0, rotationY, 0);
    }
}
