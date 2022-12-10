using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    private Animator anim;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            anim = GetComponent<Animator>();
            anim.SetTrigger("End"); 
        }     
    }  

    void NextLevel1()
    {
        SceneManager.LoadScene(0);
    }
}
