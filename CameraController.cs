using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 mousePos;
    public enum RotationAxes
    {
        mouseXY = 0,
        mouseX = 1,
        mouseY = 2
    }
    public RotationAxes axes = RotationAxes.mouseXY;

    public float sensitivity = 10f;
    private float rotationX, rotationY;

    void Start()
    {
        
    }

    void Update()
    {

        
    }
    void LateUpdate()
    {
        if (Input.GetMouseButton(0) == true)
        {
            
             rotationY +=  Input.GetAxis("Mouse X") * sensitivity;

             rotationX -= Input.GetAxis("Mouse Y") * sensitivity;


             transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);

        }
        transform.position = player.transform.position;
  
    }
}
