using UnityEngine;

public class ArrowDamage : MonoBehaviour
{
    public float RawDamage = 15;
    private bool ArrowHit = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (ArrowHit) return;
        ArrowHit = true;
     collision.collider.SendMessageUpwards("Hit", RawDamage, SendMessageOptions.DontRequireReceiver);
    
    }
}
