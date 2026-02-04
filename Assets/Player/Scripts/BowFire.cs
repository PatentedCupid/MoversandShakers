using UnityEngine;

public class BowFire : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject ArrowPrefab;
    public float ShootForce = 30f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootArrow();
        }
    }
    void ShootArrow()
    {
        GameObject Arrow = Instantiate(ArrowPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody rb = Arrow.GetComponent<Rigidbody>();
        rb.linearVelocity = FirePoint.forward * ShootForce;
    }
}

