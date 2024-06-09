using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBSTACLE : MonoBehaviour
{
    
    [SerializeField]
    private float _obstaclespeed = 4f;
 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

       transform.Translate(Vector3.left * _obstaclespeed * Time.deltaTime);
      
        if(transform.position.x < -4f)
        {

            
            Destroy(this.gameObject);

        }

    }
    
}
