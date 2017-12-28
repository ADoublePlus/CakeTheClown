using UnityEngine;

public class ResetClown : MonoBehaviour
{
    void ResetClownOnHit ()
    {
        gameObject.transform.localScale = Vector3.one;

        gameObject.GetComponentInChildren<CollisionBehavior>().collided = false;
    }
}