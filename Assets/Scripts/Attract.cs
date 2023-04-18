using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attract : MonoBehaviour
{
    public float AttractSpeed;
    public Transform pos;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            transform.position = Vector3.MoveTowards(transform.position,col.transform.position, AttractSpeed * Time.deltaTime);
            Debug.Log("h");
        }
    }
}
