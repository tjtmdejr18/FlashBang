using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookAction : MonoBehaviour
{
    Hook grap;
    public DistanceJoint2D joint2D;

    void Start()
    {
        grap = GameObject.Find("Player").GetComponent<Hook>();
        joint2D = GetComponent<DistanceJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Top"))
        {
            joint2D.enabled = true;
            grap.isAttach = true;
        }
    }
}
