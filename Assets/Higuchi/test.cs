using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * 5, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {

        
        Debug.Log(1);
        IddDamage aiai = other.gameObject.GetComponent<IddDamage>();
        if (aiai != null)
        {
            aiai.Idddamage(20);
        }
        }
    }
   
}

