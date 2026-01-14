using UnityEngine;
using UnityEngine.InputSystem;

public class jerryscript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength;
    public logicScript logic;
    public bool jerryIsAlive = true;
    //mis treba da poskoci samo jednom, ne vise puta- bool isGrounded
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    
    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame && jerryIsAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * (jumpStrength + 3f);

        }
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("trapspawn"))
        {
            logic.gameOver();
            jerryIsAlive = false;
        }
    }
}
