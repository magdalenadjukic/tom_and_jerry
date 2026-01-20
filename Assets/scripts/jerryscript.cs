using UnityEngine;
using UnityEngine.InputSystem;

public class jerryscript : MonoBehaviour
{
    [SerializeField] private float speed;
    public Rigidbody2D myRigidBody;
    public float jumpStrength;
    public logicScript logic;
    public bool jerryIsAlive = true;
    private float horizontalInput;
    //mis treba da poskoci samo jednom, ne vise puta- bool isGrounded

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
        horizontalInput = Input.GetAxis("Horizontal");

        // Ovo sluzi da mis ide levo desno
        myRigidBody.linearVelocity = new Vector2(horizontalInput * speed, myRigidBody .linearVelocity.y);

        // Ova dva if uslova flipuju figuru levo desno u zavisnosti u kom smeru ide
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(0.2751009f, 0.3365659f, 1);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-0.2751009f, 0.3365659f, 1);

        // Da skace sa space-om
        if (Input.GetKey(KeyCode.Space))
            myRigidBody.linearVelocity = new Vector2(myRigidBody.linearVelocity.x, jumpStrength);

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
