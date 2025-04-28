using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 2f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Debug.Log("finish line touched");
            if (finishEffect != null)
            {
                finishEffect.Play();
                GetComponent<AudioSource>().Play();
                Invoke(nameof(ReloadScene), loadDelay);
            }
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

