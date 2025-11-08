using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int MaxHp = 20;
    public int currentHp;

    public float Speed;
    public float ProyectileSpeed;
    public GameObject Arrow;

    public Slider hpBar;
    public GameObject GameOverPanel;

    void Start()
    {
        currentHp = MaxHp;
        hpBar.maxValue = MaxHp;
        hpBar.minValue = 0;
        hpBar.value = currentHp;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShootArrowMechanic();
        }
        MovementMechanic();
    }
    public void MovementMechanic()
    {
        if (Input.GetKey(KeyCode.W))
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
    public void ShootArrowMechanic()
    {
        Vector3 MouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
        Vector2 direction = (MouseWorldPos - transform.position).normalized;

        GameObject arrow = Instantiate(Arrow,transform.position,Quaternion.identity);

        arrow.GetComponent<Rigidbody2D>().linearVelocity = direction * ProyectileSpeed;

        float angle = Mathf.Atan2(direction.y , direction.x) * Mathf.Rad2Deg;

        arrow.transform.rotation = Quaternion.Euler(0,0, angle);

    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        if (currentHp < 0)
        {
            currentHp = 0;
            print("GameOver");
            GameOverPanel.SetActive(true);
        }
        hpBar.value = currentHp;
    }
}
