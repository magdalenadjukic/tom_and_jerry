using UnityEngine;
using UnityEngine.InputSystem;

public class jerryscript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength;

    //kontrola skoka
    //public int maxJumps = 3;
    //private int jumpCount = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame )
        {
            myRigidBody.linearVelocity = Vector2.up * jumpStrength;
           
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    // Proveri da li je mis dotakao zemlju
    //    if (collision.gameObject.CompareTag("bottom"))
    //    {
    //        jumpCount = 0;
    //    }
    //}
}
