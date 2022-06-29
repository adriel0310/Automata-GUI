using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public GameObject [] panels;
    // Start is called before the first frame update
    void Start()
    {
        panels[0].SetActive(false);
        panels[1].SetActive(false);
        panels[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RegExBtn(){
        panels[0].SetActive(false);
        panels[1].SetActive(false);
        panels[2].SetActive(false);
        panels[3].SetActive(true);
    }

    public void DFABtn(){
        panels[0].SetActive(true);
        panels[1].SetActive(false);
        panels[2].SetActive(false);
        panels[3].SetActive(false);
    }

    public void CFGBtn(){
        panels[1].SetActive(true);
        panels[0].SetActive(false);
        panels[2].SetActive(false);
        panels[3].SetActive(false);
    }

    public void PDABtn(){
        panels[2].SetActive(true);
        panels[0].SetActive(false);
        panels[1].SetActive(false);
        panels[3].SetActive(false);
    }
}
