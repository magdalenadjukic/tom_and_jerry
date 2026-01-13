using UnityEngine;
using UnityEngine.UIElements;

public class cheeseSpawnScript : MonoBehaviour
{

    public GameObject cheese;
    //public float spawnRate = 2;
    //private float timer = 0;
    public float heightOffset = 7;

    public float spawnRate = 2f;
    private float timer = 0f;

    public float minY = -3f;
    public float maxY = 3f;

    public float spawnX = 10f;
    void Start()
    {
        spawnCheese();
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
            spawnCheese();
            timer = 0;

        }
    }
    void spawnCheese()
    {
        //float lowestPoint = transform.position.y - heightOffset;
        //float highestPoint = transform.position.y + heightOffset;
        //Instantiate(cheese, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
        float spawnY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);
        Instantiate(cheese, spawnPos, Quaternion.identity);
    }
}
