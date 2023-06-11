using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDriection : MonoBehaviour
{
    Vector2 direction;
    public Transform target;

    void Update()
    {
        if(target != null)
        {
            direction = new Vector2(transform.position.x - target.position.x, transform.position.y);
        }
        if(direction.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

    }
}
