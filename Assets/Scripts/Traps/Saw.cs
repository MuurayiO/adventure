using UnityEngine;


public class Saw : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;

    private bool movingDown;
    private float VertUp;
    private float VertDown;
    public float VertSpeed;


    private void Awake()
    {
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;

        VertUp = transform.position.y + movementDistance;
        VertDown = transform.position.y - movementDistance;
    }

    private void Update()
    {
        xMove();
        yMove();
        
    }
    private void xMove()
    {
        if (movingLeft)
        {
            if (transform.position.x > leftEdge)
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingLeft = false;
            }
                
        }
        else
        {
            if (transform.position.x < rightEdge)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingLeft = true;
            }
                
        }
    }
    private void yMove()
    {
        if (movingDown)
        {
            if (transform.position.y > VertDown)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - VertSpeed * Time.deltaTime, transform.position.z);
            }
            else
            {
                movingDown = false;
            }
                
        }
        else
        {
            if (transform.position.y < VertUp)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + VertSpeed * Time.deltaTime, transform.position.z);
            }
            else
            {
                movingDown = true;
            }
                
        }
    }
}
