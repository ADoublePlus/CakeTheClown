using UnityEngine;

public class ThrowCake : MonoBehaviour
{
    public GameObject cakePrefab;
    public float throwingDelay = 0.5f;
    public float yImpulse;
    public float zImpulse;

    GameObject cake;
    float timeOfLastThrow;

    // Use this for initialization
    void Start ()
    {
        timeOfLastThrow = Time.time - throwingDelay;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonUp(0) && Time.time - timeOfLastThrow > throwingDelay)
        {
            timeOfLastThrow = Time.time;

            cake = Instantiate(cakePrefab);

            Rigidbody cakeBody = cake.GetComponent<Rigidbody>();

            cakeBody.AddForce(new Vector3(0, yImpulse, zImpulse));

            cakeBody.AddTorque(new Vector3(Random.Range(-15, 15), Random.Range(-15, 15), Random.Range(-15, 15)));
        }
    }
}