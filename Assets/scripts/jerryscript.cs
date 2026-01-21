using UnityEngine;
using UnityEngine.InputSystem;

public class jerryscript : MonoBehaviour
{
    [SerializeField] private float speed;
    public Rigidbody2D myRigidBody;

    public float jumpStrength = 10f;
    public logicScript logic;
    public bool jerryIsAlive = true;

    private bool isGrounded = false;
    public LayerMask groundLayer;

    public Transform feetPos;
    public float groundDistance = 0.25f;
    private bool isJumping = false;
    [SerializeField] private float jumpTime = 0.3f;
    private float jumpTimer;

    private void Awake()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }
    void Update()
    {
        if (!jerryIsAlive)
        {
            // zaustavi kretanje skroz kad je game over
            myRigidBody.linearVelocity = Vector2.zero;
            return;
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, groundDistance, groundLayer);
        
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded)
        {
            
            isJumping = true;
            myRigidBody.linearVelocity = Vector2.up * jumpStrength;

        }
        if(isJumping && Input.GetButton("Jump"))
        {
            
            if (jumpTimer < jumpTime)
            {
                myRigidBody.linearVelocity=Vector2.up*jumpStrength;
                jumpTimer += Time.deltaTime;
            }
            else
            {
                isJumping=false;    
            }

        }
        if (Input.GetButtonUp("Jump"))
        {
            
            isJumping = false;
            jumpTimer = 0;
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
