using UnityEngine;

public class trapMoveScript : MonoBehaviour
{
    public float moveSpeed=15;
    public float deadZone = -45;
    public logicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

    }

    void Update()
    {
        if (logic.gameIsOver) return;

        transform.position += (Vector3.left * moveSpeed)*Time.deltaTime;
        if(transform.position.x<deadZone)
        {
            Destroy(gameObject);

        }
    }
}
