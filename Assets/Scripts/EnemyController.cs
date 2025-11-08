using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator animator;
    public GameObject Target;
    public float Speed;
    public float AttackRange;
    public int Damage;



    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CheckOrientation();
        //Debug.Log( Vector3.Distance(Target.transform.position, transform.position));
        float distance = Vector3.Distance(Target.transform.position, transform.position);
        if (distance <= AttackRange)
        {
            
            animator.SetBool("AttackState", true);
        }
        else
        {
            Vector3 Dir = (Target.transform.position - transform.position).normalized;

            transform.position += Dir * Speed * Time.deltaTime;

            animator.SetBool("AttackState", false);

        }


        
    }
    public void CheckOrientation()
    {
        if(transform.position.x >= Target.transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().TakeDamage(Damage);

           Destroy(gameObject);
        }*/
    }
    public void AttackPlayer()
    {
        Target.GetComponent<PlayerController>().TakeDamage(Damage);

        Destroy(gameObject);
    }
}
