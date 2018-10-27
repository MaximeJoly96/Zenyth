using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Projectile component = collision.GetComponent<Projectile>();
        if (component)
            Destroy(collision.gameObject);
    }
}
