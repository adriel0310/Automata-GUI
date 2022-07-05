using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutButton : MonoBehaviour
{
    public GameObject [] panels;
    //public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AboutOpen(){
        panels[0].SetActive(true);
        panels[1].SetActive(false);
        panels[2].SetActive(false);
        panels[3].SetActive(false);
        panels[4].SetActive(false);
        panels[5].SetActive(false);
        panels[6].SetActive(false);
        //panel.SetActive(true);
    }

    public void AboutClose(){
        panels[0].SetActive(false);
        panels[1].SetActive(true);
        panels[2].SetActive(false);
        panels[3].SetActive(false);
        panels[4].SetActive(false);
        panels[5].SetActive(false);
        panels[6].SetActive(true);
    }
}
