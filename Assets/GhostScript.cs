using UnityEngine;

public class GhostScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrengt;
    public LogicScript logic;
    public bool GhostIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GhostIsAlive) //This asks Unity if the space key has been pressed and if the bird is still alive (both are true)
        {
        myRigidbody.linearVelocity = Vector2.up * flapStrengt; //sends the bird ap in the scy
        }

        if (transform.position.y > Camera.main.orthographicSize || 
            transform.position.y < - Camera.main.orthographicSize)
        {
            logic.gameOver();
            GhostIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        GhostIsAlive = false;
    }
}
