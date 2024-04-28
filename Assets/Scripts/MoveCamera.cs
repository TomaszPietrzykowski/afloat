using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosision;

    // Update is called once per frame
    private void Update()
    {
        transform.position = cameraPosision.position;
    }
}
