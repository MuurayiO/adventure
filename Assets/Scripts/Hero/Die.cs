using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    private Animator anim;
    private BoxCollider2D cd;

    private void Start()
    {
        anim = GetComponent<Animator>();
        cd = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            GetComponent<Movement>().enabled = false;
            cd.enabled = false;
            anim.SetTrigger("die");
        }     
    }  

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
