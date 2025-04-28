using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") && !hasCrashed)
        {
            // Debug.Log("Ooch... My head");
            if (crashEffect != null)
            {
                hasCrashed = true;
                FindAnyObjectByType<PlayerController>().DisableControl();
                crashEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
                Invoke(nameof(ReloadScene), loadDelay);
            }
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
