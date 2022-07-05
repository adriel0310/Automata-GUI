using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DFAButton : MonoBehaviour
{
    public Text given;
    public Toggle toggle1;
    public Toggle toggle2;
    public GameObject given1;
    public GameObject given2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        givenText();
    }

    public void givenText(){
        if(toggle1.isOn){
            given.text= "(b+aa+ab) (a+b)* (bb+aba+ab)* (aaa+bbb) (a+b) (a+b+ab)*";
            given1.SetActive(true);
            given2.SetActive(false);
        }
        if(toggle2.isOn){
            given.text= "(1+0)* (11+00+101+010) (1+0+11+00+101)* (11+00) (11+00+101)* (1+0) (1+0+11)*";
            given2.SetActive(true);
            given1.SetActive(false);
        }
    }
}
