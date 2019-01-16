using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float MoveSpeed;
    [SerializeField] private Vector3 StartPos;
    [SerializeField] private Vector2 X_bound;
    public int InitHealth;

    public int CurrentHealth { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        transform.position = StartPos;
        CurrentHealth = InitHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (true)   // boundary
        {
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > X_bound.x)
            {
                transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < X_bound.y)
            {
                transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
            }
        }
    }

    public void TakeDamage(int dmg) {
        if (CurrentHealth > 0) {
            CurrentHealth -= dmg;
        }
        if (CurrentHealth <= 0)
        {
            Debug.Log("You Died!");
            Death();
        }
    }

    void Death() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage(collision.GetComponent<Obstacle>().Damage);
        Destroy(collision.gameObject);
    }
}
