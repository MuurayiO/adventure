using UnityEngine;

public class RockHead : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground1"))
        {
            GetComponent<Animator>().SetTrigger("Down");
        }  
    }
}
