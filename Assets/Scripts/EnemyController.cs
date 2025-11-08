using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Target;
    public float Speed;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Dir = (Target.transform.position - transform.position).normalized;

        transform.position += Dir * Speed * Time.deltaTime;
    }
}
