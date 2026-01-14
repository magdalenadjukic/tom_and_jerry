using UnityEngine;

public class trapSpawnScript : MonoBehaviour
{
    public GameObject trap;
    public float spawnRate;
    private float timer = 0;
    //public float startDelay = 3f;
    void Start()
    {
        spawnTrap();
        spawnRate = Random.Range(1.5f, 3f);
       // timer = -startDelay;
    }

    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTrap();
            timer = 0;

        }

        //timer += Time.deltaTime;

     
        //if (timer >= spawnRate)
        //{
        //    spawnTrap();       
        //    timer = 0f;        

        //}

    }

    void spawnTrap()
    {
        
        Instantiate(trap, transform.position, transform.rotation);
    }
}
