using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneManager : MonoBehaviour
{
    [SerializeField] private Text _timeScore;

    // Start is called before the first frame update
    void Start()
    {
        _timeScore = _timeScore.gameObject.GetComponent<Text>();
        _timeScore.text = GameManager.Time.ToString("F");
    }
}
