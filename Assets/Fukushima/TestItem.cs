using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("当たってる");
        if (other.gameObject.name == "TestPlayer")
        {
            Debug.Log("TestPlayerに当たってる");
            Iitem _item = other.gameObject.GetComponent<Iitem>();
            if (_item != null)
            {
                _item.AddHP(5);
                Debug.Log("HP + 5");
                Destroy(this.gameObject);
            }

        }
    }
}
