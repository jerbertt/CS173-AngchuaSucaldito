using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject camHolder;
    public float speed, sensitivity, maxForce;
    private Vector2 move, look;
    private float lookRotation;

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        look = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (Score_Control.time < 60)
        {
            //find target velocity
            Vector3 currentVelocity = rb.velocity;
            Vector3 targetVelocity = new Vector3(move.x, 0, move.y);
            currentVelocity.y = 0; // Ensure y-velocity is ignored

            targetVelocity *= speed;

            //align direction
            targetVelocity = transform.TransformDirection(targetVelocity);

            //calculate forces
            Vector3 velocityChange = (targetVelocity - currentVelocity);

            velocityChange = Vector3.ClampMagnitude(velocityChange, maxForce);


            rb.AddForce(velocityChange, ForceMode.VelocityChange);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Lock the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;

        // Make the cursor invisible
        Cursor.visible = false;

        CapsuleCollider capsuleCollider = GetComponent<CapsuleCollider>();
        capsuleCollider.enabled = false;
        // Optionally, wait a frame or two to let physics stabilize
        StartCoroutine(EnableColliderAfterDelay(0.1f)); 
    }

IEnumerator EnableColliderAfterDelay(float delay)
{
    yield return new WaitForSeconds(delay);
    GetComponent<CapsuleCollider>().enabled = true;
}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Unlock and show the cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            // Lock and hide the cursor when clicking the left mouse button
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }


    // Update is called once per frame
    void LateUpdate()
    {
        if(Score_Control.time < 60)
        {
            // Turn the player (left/right rotation)
            rb.MoveRotation(rb.rotation * Quaternion.Euler(Vector3.up * look.x * sensitivity));

            // Update and clamp the vertical look rotation (up/down)
            lookRotation += -look.y * sensitivity;
            lookRotation = Mathf.Clamp(lookRotation, -90f,50f); // Clamp between -90 (down) and 90 (up)

            // Apply the rotation explicitly on the x-axis, preserve other axes
            Quaternion cameraRotation = Quaternion.Euler(lookRotation, 0f, 0f);
            camHolder.transform.localRotation = cameraRotation;
        }

    }



}
