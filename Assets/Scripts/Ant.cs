using UnityEngine;

public class Ant : Enemy
{

    public override void Behavior()
    {
        throw new System.NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(20);
        DamageHit = 20;
    }

}
