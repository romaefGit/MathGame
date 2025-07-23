using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerBehaviour.Instance.gameObject)
        {
            Debug.Log("<<< Colisiona contra la ola >>>");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == PlayerBehaviour.Instance.gameObject)
        {
            Debug.Log("<<< Está adentro >>>");

        }
    }
}
