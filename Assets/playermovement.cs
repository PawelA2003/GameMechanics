using UnityEngine;

public class playermovement : MonoBehaviour {
 
    public CharacterController2D CharacterController;

    public float runSpeed = 80f;

    float horizontalmove = 0f;
    bool jump = false;
    bool crouch = false;
    
    void Update () {

        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown ("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    
    void FixedUpdate()
    {
        CharacterController.Move(horizontalmove * Time.fixedDeltaTime, crouch, jump); 
        jump = false;
    }

}
