using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystickController : MonoBehaviour
{

    //public Rigidbody rb;

    public float speed = 5.0F;
    public DynamicJoystick moveJoystick;
    public DynamicJoystick lookJoystick;

    void Update()
    {

        updateMoveJoystick();
        updateLookJoystick();

    }

    void updateMoveJoystick()
    {
        CharacterController controller = GetComponent<CharacterController>();
        float hoz = moveJoystick.Horizontal;
        float ver = moveJoystick.Vertical;
        Vector3 direction = new Vector3(hoz, 0, ver).normalized;
        controller.SimpleMove(direction *speed);
 
    }

    void updateLookJoystick()
    {
        float hoz = moveJoystick.Horizontal;
        float ver = moveJoystick.Vertical;
        Vector3 direction = new Vector3(hoz, 0, ver).normalized;
        Vector3 lookAtPosition = transform.position + direction;
        transform.LookAt(lookAtPosition);
    }
    private void FixedUpdate()
    { /*
        if (rb.position.y < -4)
        {
            FindObjectOfType<GameController>().EndGame();
        }
        */
    }
}
