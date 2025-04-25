using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground")){
            Debug.Log("Ooch... My head");
        }
    }
}
