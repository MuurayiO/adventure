using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private Animator anim;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            anim = GetComponent<Animator>();
            anim.SetTrigger("Finish"); 
        }     
    }  

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
