using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_crane : MonoBehaviour
{
    public Instantiate instantiate;
    public Transform target;
    public float speed;
    void Start()
    {
      //transform.Translate(5f, 0f, 0f);
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
      if(target.position.x > transform.position.x) transform.position = new Vector3(transform.position.x + step, transform.position.y, transform.position.z);
      if(target.position.x < transform.position.x) transform.position = new Vector3(transform.position.x - step, transform.position.y, transform.position.z);      
    }
}
