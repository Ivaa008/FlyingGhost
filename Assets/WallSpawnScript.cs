using Unity.VisualScripting;
using UnityEngine;

public class WallSpawnScript : MonoBehaviour
{
    public GameObject wall;
    //spawner
    // how many seconds before spawns
    public float spawnRate = 2;
    //the number that counts up
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnWall();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            //timer = timer + Time.deltaTime;
            timer += Time.deltaTime; //if the timer is less that the spawn rate then count the time up
        }
        else
        {
            spawnWall();
            timer = 0; //if not we start the timer again
        }
    }

    void spawnWall()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
                                       //x,y,z         
        Instantiate(wall, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
