using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float bounce;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            GetComponent<Animator>().SetTrigger("Jump");
        }  
    }
}
