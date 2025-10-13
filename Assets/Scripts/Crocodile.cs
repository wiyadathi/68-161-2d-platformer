using UnityEngine;

public class Crocodile : Enemy
{

    void Start()
    {
        base.Initialize(50);
        DamageHit = 30;
    }

    public override void Behavior()
    {
        throw new System.NotImplementedException();
    }

}
