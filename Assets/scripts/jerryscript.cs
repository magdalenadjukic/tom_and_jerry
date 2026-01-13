using UnityEngine;
using UnityEngine.InputSystem;

public class jerryscript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            myRigidBody.linearVelocity = Vector2.up * jumpStrength;
        }
    }
}
