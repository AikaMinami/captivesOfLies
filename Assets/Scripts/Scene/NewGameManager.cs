using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGameManager : MonoBehaviour
{
    public GameObject btnStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNewGame()
    {
    //     PlayerPrefs.DeleteAll();
    //     PlayerPrefs.SetInt("firstTimeInClassroom", 0);
        btnStart.SetActive(false);
    }
}
