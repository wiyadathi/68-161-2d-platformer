using UnityEngine;

public class Player : Character
{
    //no additional attributes, use Base class attributes

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(100); //set Player's Health
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null) {
            Debug.Log($"{this.name} Hit with {enemy.name}!");
            OnHitWith(enemy);
        }
    }
}
