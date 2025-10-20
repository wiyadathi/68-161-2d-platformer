using UnityEditor.Tilemaps;
using UnityEngine;

public class Ant : Enemy
{
    public Vector2 velocity;
    public Transform[] movePoints;

    void Start()
    {
        base.Initialize(20);
        DamageHit = 20;

        //set speed and direction of movement
        velocity = new Vector2(-1.0f, 0.0f);
    }

    public override void Behavior()
    {
        //move
        rb.MovePosition( rb.position + velocity * Time.fixedDeltaTime );

        //move left ����Թ�ͺ����
        if ( velocity.x < 0 && rb.position.x <= movePoints[0].position.x )
        {
            Flip();
        }

        //move right ����Թ�ͺ���
        if (velocity.x > 0 && rb.position.x >= movePoints[1].position.x)
        {
            Flip();
        }
    }

    //flip ant to the opposite idrection
    public void Flip()
    {
        velocity.x *= -1; //change direction of movement

        //Flip the image
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void FixedUpdate()
    {
        Behavior();
    }
}

