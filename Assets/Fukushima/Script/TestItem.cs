using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem : MonoBehaviour
{
    public AudioClip _scream;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�������Ă�");
        //"�@"����player��object���ɕύX���Ă������� 
        if (collision.gameObject.name == "TestPlayer")
        {
            Debug.Log("TestPlayer�ɓ������Ă�");
            Iitem _item = collision.gameObject.GetComponent<Iitem>();
            if (_item != null)
            {
                _item.AddHP(5);
                Debug.Log("HP + 5");
                AudioSource.PlayClipAtPoint(_scream,this.transform.position);
                Destroy(this.gameObject);
            }
        }
    }
}
