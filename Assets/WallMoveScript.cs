using UnityEngine;

public class WallMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 
        //happens the same no matter the frame rate
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
