using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;

    Vector3 up = new Vector3(0, 1, 0);
    void Start()
    {
       // +
       // -
       // /
       // %   7 % 3
       // +=
       // ++
       // --
        // -=

        // (0,1,0)
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }
    }
}
