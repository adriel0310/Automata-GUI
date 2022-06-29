using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectToggle : MonoBehaviour
{
    public Toggle Toggle1;
    public Toggle Toggle2;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void checkError()
    {
        if(!Toggle1.isOn && !Toggle2.isOn){
            Debug.Log("wala check");
            panel.SetActive(true);
        }
    }

    public void Close(){
        panel.SetActive(false);
    }
}
