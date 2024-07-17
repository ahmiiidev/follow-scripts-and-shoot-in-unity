using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

    public float speed;
    public Transform target;
    public float minimumdistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position,target.position) > minimumdistance)

        {

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }

        
        
        
    }
}
