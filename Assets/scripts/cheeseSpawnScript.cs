using UnityEngine;
using UnityEngine.UIElements;

public class cheeseSpawnScript : MonoBehaviour
{
    public logicScript logic;

    public GameObject cheese;
    
    public float heightOffset = 7;

    public float spawnRate = 2f;
    private float timer = 0f;

    public float minY = -3f;
    public float maxY = 3f;

    public float spawnX = 10f;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

        spawnCheese();
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
            spawnCheese();
            timer = 0;

        }
    }
    void spawnCheese()
    {
        
        float spawnY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);
        Instantiate(cheese, spawnPos, Quaternion.identity);
    }
}
