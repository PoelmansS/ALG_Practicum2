using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_crane_z : MonoBehaviour
{
    public Instantiate instantiate;
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = target.position;
    }

    // Start is called before the first frame update
    void Awake()
    {
        instantiate = FindObjectOfType<Instantiate>();
        int nr_of_objects = instantiate.nr_of_objects;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        if(target.position.z > transform.position.z) transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + step);
        if(target.position.z < transform.position.z) transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - step);        
    }
}
