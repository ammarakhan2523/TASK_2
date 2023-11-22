using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {


       
        PlayerController.count+=1;
        Destroy(gameObject);
        if(PlayerController.count == 3)
        {
            PlayerController.count = 0;
            PlayerController.star += 1;
        }

    }
}
