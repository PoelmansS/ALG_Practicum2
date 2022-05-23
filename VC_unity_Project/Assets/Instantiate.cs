using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Instantiate : MonoBehaviour
{
    [SerializeField] public int nr_of_objects;
    [SerializeField] public GameObject block;


    void Start(){
        System.Console.WriteLine("update called");
        for(int i = 0; i < nr_of_objects; i++){
            Vector3 random_spawn_pos = new Vector3(Random.Range(-4f,4f), 4f, Random.Range(-4f, 4f)); 
            Instantiate(block, random_spawn_pos, Quaternion.identity);
           
            System.Console.WriteLine("added new object");
        }
    }
}
