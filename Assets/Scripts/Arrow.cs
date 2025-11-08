using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
   // public Rigidbody2D rb;
    void Start()
    {
        Destroy(gameObject,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
