using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genertator : MonoBehaviour
{

    // ��������v���n�u�i�[�p
    public GameObject PrefabCube;
    public GameObject PrefabCube2;

    public GameObject PrefabMuteki;



    public int timeOut;
    public int timeOut2;
    public int Muteki;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Randam());
        StartCoroutine(Randam2());
        StartCoroutine(Randam3());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Randam()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeOut);

            // �v���n�u�̈ʒu�������_���Őݒ�
            float x = Random.Range(9f, 10f);
            float z = Random.Range(0f, 0f);
            float y = Random.Range(-4f, 2f);
            Vector3 pos = new Vector3(x, y, z);

            // �v���n�u�𐶐�
            Instantiate(PrefabCube, pos, Quaternion.identity);
        }

    }

    private IEnumerator Randam2()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeOut2);

            // �v���n�u�̈ʒu�������_���Őݒ�
            float x = Random.Range(9f, 10f);
            float z = Random.Range(0f, 0f);
            float y = Random.Range(-4f, 2f);
            Vector3 pos = new Vector3(x, y, z);

            // �v���n�u�𐶐�
            Instantiate(PrefabCube2, pos, Quaternion.identity);
        }

    }

    private IEnumerator Randam3()
    {
        while (true)
        {
            yield return new WaitForSeconds(Muteki);

            // �v���n�u�̈ʒu�������_���Őݒ�
            float x = Random.Range(9f, 10f);
            float z = Random.Range(0f, 0f);
            float y = Random.Range(-4f, 2f);
            Vector3 pos = new Vector3(x, y, z);

            // �v���n�u�𐶐�
            Instantiate(PrefabMuteki, pos, Quaternion.identity);
        }

    }
}
