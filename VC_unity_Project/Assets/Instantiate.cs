using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Instantiate : MonoBehaviour
{
    [SerializeField] public int nr_of_objects;
    [SerializeField] public GameObject block;


    void update()
    {
        System.Console.WriteLine("update called");
        int i = 0;
        while (i < nr_of_objects){
            i++;
            Vector3 random_spawn_pos = new Vector3(Random.Range(-5f,5f), 5f, Random.Range(-5f, 5f)); 
            Instantiate(block, random_spawn_pos, Quaternion.identity);
           
            System.Console.WriteLine("added new object");
        }
    }
}
