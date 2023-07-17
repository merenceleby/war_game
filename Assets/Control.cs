using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject camera;
    public float speed = 5.0f; 
    public float sens = 5.0f;
    private float rotx = 0.0f;
    private float roty = 0.0f;
    private Rigidbody rb;
    private float movehorizontal;
    private float movevertical;
    private Vector3 move;

    void Start()
    {

    rb = GetComponent<Rigidbody>();
    Cursor.lockState = CursorLockMode.Locked; 
    }


    void Update()
    {
        characterMoving();
        cameraRot();
    }
    void characterMoving()
    {
        movehorizontal = Input.GetAxis("Horizontal");
        movevertical = Input.GetAxis("Vertical");
        move = new Vector3(movehorizontal, 0.0f, movevertical);
        move = transform.TransformDirection(move);
    }
    void cameraRot()
    {
        rotx -= Input.GetAxis("Mouse Y") * sens;
        roty += Input.GetAxis("Mouse X") * sens;


        rotx = Mathf.Clamp(rotx, -90, 90);
        camera.transform.localRotation = Quaternion.Euler(rotx, 0, 0);
        transform.rotation = Quaternion.Euler(0, roty, 0);
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + (move * speed * Time.fixedDeltaTime));
  
    }

}
