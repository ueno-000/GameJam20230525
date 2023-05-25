using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genertator : MonoBehaviour
{

    // 生成するプレハブ格納用
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

            // プレハブの位置をランダムで設定
            float x = Random.Range(9f, 10f);
            float z = Random.Range(0f, 0f);
            float y = Random.Range(-4f, 2f);
            Vector3 pos = new Vector3(x, y, z);

            // プレハブを生成
            Instantiate(PrefabCube, pos, Quaternion.identity);
        }

    }

    private IEnumerator Randam2()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeOut2);

            // プレハブの位置をランダムで設定
            float x = Random.Range(9f, 10f);
            float z = Random.Range(0f, 0f);
            float y = Random.Range(-4f, 2f);
            Vector3 pos = new Vector3(x, y, z);

            // プレハブを生成
            Instantiate(PrefabCube2, pos, Quaternion.identity);
        }

    }

    private IEnumerator Randam3()
    {
        while (true)
        {
            yield return new WaitForSeconds(Muteki);

            // プレハブの位置をランダムで設定
            float x = Random.Range(9f, 10f);
            float z = Random.Range(0f, 0f);
            float y = Random.Range(-4f, 2f);
            Vector3 pos = new Vector3(x, y, z);

            // プレハブを生成
            Instantiate(PrefabMuteki, pos, Quaternion.identity);
        }

    }
}
