using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CFGButton : MonoBehaviour
{
    public Text given;

    public Toggle toggle1;
    public Toggle toggle2;

    public GameObject ans1;
    public GameObject ans2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void givenText(){
        if(toggle1.isOn){
            given.text= "(b+aa+ab) (a+b)* (bb+aba+ab)* (aaa+bbb) (a+b) (a+b+ab)*";
            ans1.SetActive(true);
            ans2.SetActive(false);
        }
        if(toggle2.isOn){
            given.text= "(1+0)* (11+00+101+010) (1+0+11+00+101)* (11+00) (11+00+101)* (1+0) (1+0+11)*";
            ans1.SetActive(false);
            ans2.SetActive(true);   
        }
    }
}
