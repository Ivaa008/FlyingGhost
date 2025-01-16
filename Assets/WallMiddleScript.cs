using UnityEngine;

public class WallMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //so the WallMiddleScript can ttalk to the LogicScript
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks if the colision happend on the bird's layer (i put the ghost on the 3rd layer)
        if (logic != null && collision.gameObject.layer == 3 && logic.gameOverScreen.activeSelf == false)
        {
            logic.addScore(1);
        }
        
    }
}
