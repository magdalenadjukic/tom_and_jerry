using UnityEngine;

public class trapSpawnScript : MonoBehaviour
{
    public GameObject trap;
    public float spawnRate = 2;
    private float timer = 0;
    //public float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTrap();
    }

    // Update is called once per frame
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
        
    }

    void spawnTrap()
    {
        
        Instantiate(trap, transform.position, transform.rotation);
    }
}
