using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20;
    public float bound = 20;
    public bool forward = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (forward)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }else
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime, Space.World);
        }
        

        if (transform.position.x > bound)
        {
            Destroy(gameObject);
        }
    }
}
