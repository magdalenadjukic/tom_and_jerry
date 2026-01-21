using UnityEngine;

public class cheeseCatch : MonoBehaviour
{
    public logicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            Destroy(gameObject);
        }
    }
}
