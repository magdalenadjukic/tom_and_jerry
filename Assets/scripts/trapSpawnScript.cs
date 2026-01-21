using UnityEngine;

public class trapSpawnScript : MonoBehaviour
{
    public logicScript logic;

    public GameObject trap;
    public float spawnRate;
    private float timer = 0;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

        spawnTrap();
        spawnRate = Random.Range(1.5f, 3f);
    }

    void Update()
    {
        if (logic.gameIsOver) return;

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTrap();
            timer = 0;

        }

      
    }

    void spawnTrap()
    {
        
        Instantiate(trap, transform.position, transform.rotation);
    }
}
