using UnityEngine;

public abstract class Enemy : Character
{
    //auto-property
    public int DamageHit { get; set; }

    //abstract method for enemy
    public abstract void Behavior();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
