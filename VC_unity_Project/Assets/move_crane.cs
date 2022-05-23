using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_crane : MonoBehaviour
{   
    public Instantiate instantiate;
    
    // Start is called before the first frame update
    void Awake()
    {
        instantiate = FindObjectOfType<Instantiate>();
        int nr_of_objects = instantiate.nr_of_objects;
    }

    // Update is called once per frame
    void Update()
    {
       // for (int )
    }
}
