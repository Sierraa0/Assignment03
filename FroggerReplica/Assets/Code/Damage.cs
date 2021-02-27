using UnityEngine;

public class Damage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Car")
        {
            Debug.Log("Collision Detected:" + collision.gameObject.name);
            Destroy(collision.gameObject);
        }
    }

}
