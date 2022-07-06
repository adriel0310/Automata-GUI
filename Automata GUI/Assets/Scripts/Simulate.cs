using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Simulate : MonoBehaviour
{
    public TMP_InputField user_Input;
    DetectToggle detectToggle;

    //DFA ITEM 1 ANIMATORS
    public Animator anim;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    public Animator anim7;
    public Animator anim8;

    //DFA ITEM 2 ANIMATORS
    public Animator Animate;
    public Animator Animate2;
    public Animator Animate3;
    public Animator Animate4;
    public Animator Animate5;
    public Animator Animate6;
    public Animator Animate7;
    public Animator Animate8;
    public Animator Animate9;

    int FadeState = 2;
    void Start()
    {
        detectToggle = GameObject.Find("ScriptHolder").GetComponent<DetectToggle>();
    }

    /*
     * Errors with "Invalid # outside" are strings that are less than the states length
     */

    //Variable for storing user input
    string user_input;

    public void transition_state(string user_input)
    {
        int cursor = 0;
        if(detectToggle.Toggle1.isOn)
        {
            user_input = user_Input.text;
         
         foreach (char x in user_input)
            {
             cursor = 0;
             switch (cursor)
             {
                 case 0:
                     Debug.Log("Initial State");
                     if (cursor < user_input.Length)
                     {
                        StartCoroutine(DelayAnimation(1,anim,"DFA1S1",FadeState));
                          if (user_input[cursor] == 'a')
                            {  
                                StartCoroutine(DelayAnimation(2,anim2,"DFA2S1",FadeState));
                                cursor++;
                                goto case 1;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                StartCoroutine(DelayAnimation(2,anim3,"DFA3S1",FadeState));
                                cursor++;
                                goto case 2;
                            }
                            else
                            {
                                //Debug.Log("Invalid 0");
                               // ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 0 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 1:
                        Debug.Log("State 2");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                StartCoroutine(DelayAnimation(3,anim4,"DFA4S1",FadeState));
                                //anim2.SetBool("DFA2S1",true);
                                cursor++;
                                goto case 3;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                StartCoroutine(DelayAnimation(3,anim3,"DFA3S1",FadeState));
                                //anim2.SetBool("DFA2S1",true);
                                cursor++;
                                goto case 2;
                            }
                            else
                            {
                                //Debug.Log("Invalid 1");
                               //ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 1 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 2:
                        Debug.Log("State 3");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                StartCoroutine(DelayAnimation(4,anim4,"DFA4S1",FadeState));
                                //anim3.SetBool("DFA3S1",true);
                                cursor++;
                                goto case 3;
                            }
                            else
                            {
                                //Debug.Log("Invalid 2");
                                //ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 2 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 3:
                        Debug.Log("State 4");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                StartCoroutine(DelayAnimation(5,anim5,"DFA5S1",FadeState));
                                cursor++;
                                goto case 4;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                StartCoroutine(DelayAnimation(5,anim6,"DFA6S1",FadeState));
                                cursor++;
                                goto case 5;
                            }
                            else
                            {
                                //Debug.Log("Invalid 3");
                                //ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 3 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 4:
                        Debug.Log("State 5");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                StartCoroutine(DelayAnimation(7,anim7,"DFA7S1",FadeState));
                                cursor++;
                                goto case 6;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                StartCoroutine(DelayAnimation(6,anim6,"DFA6S1",FadeState));
                                cursor++;
                                goto case 5;
                            }
                            else
                            {
                                //Debug.Log("Invalid 4");
                                //ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 4 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 5:
                        Debug.Log("State 6");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                StartCoroutine(DelayAnimation(6,anim5,"DFA5S1",FadeState));
                                cursor++;
                                goto case 4;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                StartCoroutine(DelayAnimation(7,anim7,"DFA7S1",FadeState));
                                cursor++;
                                goto case 6;
                            }
                            else
                            {
                                //Debug.Log("Invalid 5");
                                //ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 5 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 6:
                        cursor--;
                        Debug.Log("State 7");
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                StartCoroutine(DelayAnimation(8,anim8,"DFA8S1",FadeState));
                                cursor++;
                                goto case 7;
                            }
                            else
                            {
                                //Debug.Log("Invalid 6");
                                //ValidityCheck.text = "Invalid";
                                
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 6 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 7:
                        Debug.Log("State 8");
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                StartCoroutine(DelayAnimation(9,anim8,"DFA8S1",FadeState));
                                cursor++;
                                goto case 7;
                            }
                            else
                            {
                                //ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else if (cursor == user_input.Length - 1)
                        {
                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                //ValidityCheck.text = "Valid";
                                //Debug.Log("Cursor: " + cursor);
                                //Debug.Log("Valid");
                                return;
                            }
                            else
                            {
                                //ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        break;
                    default:
                        //Debug.Log("Invalid End");
                        //ValidityCheck.text = "Invalid End";
                        break;
                }
            }
        } 
    }
    

// ITEM 2 
    public void transition_state_number(string user_input)
    {
         
        if(detectToggle.Toggle2.isOn)
        {
            user_input = user_Input.text;
         int cursor = 0;
         foreach (char x in user_input)
            {
             cursor = 0;   
             switch (cursor)
             {
                 case 0:
                     Debug.Log("Initial State");
                     if (cursor < user_input.Length)
                     {
                         StartCoroutine(DelayAnimation(1,Animate,"DFA1S2",FadeState));

                          if (user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(2,Animate2,"DFA2S2",FadeState));
                                cursor++;
                                goto case 1;
                            }
                            else if (user_input[cursor] == '1')
                            {
                                StartCoroutine(DelayAnimation(2,Animate3,"DFA3S2",FadeState));
                                cursor++;
                                goto case 2;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    case 1:
                        Debug.Log("State 2");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(3,Animate5,"DFA5S2",FadeState));
                                cursor++;
                                goto case 4;
                            }
                            else if (user_input[cursor] == '1')
                            {
                                StartCoroutine(DelayAnimation(3,Animate4,"DFA4S2",FadeState));
                                cursor++;
                                goto case 3;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    case 2:
                        Debug.Log("State 3");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(4,Animate4,"DFA4S2",FadeState));
                                cursor++;
                                goto case 3;
                            }

                            else if(user_input[cursor] == '1')
                            {
                                StartCoroutine(DelayAnimation(4,Animate5,"DFA5S2",FadeState));
                                cursor++;
                                goto case 4; 
                            }

                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    case 3:
                        Debug.Log("State 4");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(5,Animate5,"DFA5S2",FadeState));
                                cursor++;
                                goto case 4;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    case 4:
                        Debug.Log("State 5");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                StartCoroutine(DelayAnimation(6,Animate6,"DFA6S2",FadeState));
                                cursor++;
                                goto case 5;
                            }
                            else if (user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(6,Animate7,"DFA7S2",FadeState));
                                cursor++;
                                goto case 6;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    case 5:
                        Debug.Log("State 6");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                StartCoroutine(DelayAnimation(8,Animate8,"DFA8S2",FadeState));
                                cursor++;
                                goto case 7;
                            }
                            else if (user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(6,Animate7,"DFA7S2",FadeState));
                                cursor++;
                                goto case 6;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    case 6:
                        Debug.Log("State 7");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                StartCoroutine(DelayAnimation(7,Animate6,"DFA6S2",FadeState));
                                cursor++;
                                goto case 5;
                            }
                            if (user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(9,Animate8,"DFA8S2",FadeState));
                                cursor++;
                                goto case 7;
                            }
                            else
                            {
                                //Debug.Log("Invalid 6");
                                //ValidityCheck.text = "Invalid";
                                
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 6 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 7:
                        cursor--;
                        Debug.Log("State 8");
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(10,Animate9,"DFA9S2",FadeState));
                                cursor++;
                                goto case 8;
                            }
                            else
                            {
                                //Debug.Log("Invalid 6");
                                //ValidityCheck.text = "Invalid";
                                
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 6 outside");
                            //ValidityCheck.text = "Invalid";
                            return;
                        }

                    case 8:
                        Debug.Log("State 9");
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(11,Animate9,"DFA9S2",FadeState));
                                cursor++;
                                goto case 8;
                            }
                            else
                            {
                                //ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else if (cursor == user_input.Length - 1)
                        {
                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
                                StartCoroutine(DelayAnimation(11,Animate9,"DFA9S2",FadeState));
                                //ValidityCheck.text = "Valid";
                                 Debug.Log("Cursor: " + cursor);
                                //Debug.Log("Valid");
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        } 
    }
    
    
    IEnumerator DelayAnimation (int secDelay, Animator anim, string State,int FadeState) 
    {  
        yield return new WaitForSeconds(secDelay);
        anim.SetBool(State,true);
        yield return new WaitForSeconds(FadeState);
        anim.SetBool(State,false);
    }
}
