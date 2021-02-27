using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject frogger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if(frogger.transform.position.x > 6)
            {
                frogger.transform.position = new Vector2(frogger.transform.position.x-1, frogger.transform.position.y);
            }
            if(frogger.transform.position.x < -6)
            {
                frogger.transform.position = new Vector2(frogger.transform.position.x+1, frogger.transform.position.y);
            }
            if(frogger.transform.position.y  < -4)
            {
                frogger.transform.position = new Vector2(frogger.transform.position.x, -4);
            }
        }
    }
}
