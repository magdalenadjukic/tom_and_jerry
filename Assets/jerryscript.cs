using UnityEngine;
using UnityEngine.InputSystem;

public class jerryscript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            myRigidBody.linearVelocity = Vector2.up *jumpStrength;
        }
        

    }
}
