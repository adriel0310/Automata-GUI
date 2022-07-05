using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegexButton : MonoBehaviour
{
    public Toggle toggle1;
    public Toggle toggle2;

    public GameObject Dfa1;
    public GameObject Dfa2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SimulationDiagram();
    }
    public void SimulationDiagram(){
        if(toggle1.isOn){
            //given.text= "(b+aa+ab) (a+b)* (bb+aba+ab)* (aaa+bbb) (a+b) (a+b+ab)*";
            Dfa1.SetActive(true);
            Dfa2.SetActive(false);
        }
        if(toggle2.isOn){
            //given.text= "(1+0)* (11+00+101+010) (1+0+11+00+101)* (11+00) (11+00+101)* (1+0) (1+0+11)*";
            Dfa2.SetActive(true);
            Dfa1.SetActive(false);
        }
    }
}