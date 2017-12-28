using UnityEngine;

public class CleanUpCake : MonoBehaviour
{

    void OnBecameInvisible ()
    {
        Destroy(gameObject);
    }
}