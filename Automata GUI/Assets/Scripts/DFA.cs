using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DFA : MonoBehaviour
{
    public TMP_InputField user_Input;
    public Text ValidityCheck;
    DetectToggle detectToggle;

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
        
         cursor = 0;
         foreach (char x in user_input)
            {
             
             switch (cursor)
             {
                 case 0:
                     Debug.Log("Initial State");
                     if (cursor < user_input.Length)
                     {
                          if (user_input[cursor] == 'a')
                            {  
                                //StartCoroutine(DelayAnimation(1,anim,"DFA1S1",3));
                                cursor++;
                                goto case 1;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                //StartCoroutine(DelayAnimation(1,anim,"DFA1S1",3));
                                cursor++;
                                goto case 2;
                            }
                            else
                            {
                                Debug.Log("Invalid 0");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 0 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 1:
                        Debug.Log("State 2");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                //StartCoroutine(DelayAnimation(2,anim2,"DFA2S1",4));
                                //anim2.SetBool("DFA2S1",true);
                                cursor++;
                                goto case 3;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                //StartCoroutine(DelayAnimation(2,anim2,"DFA2S1",4));
                                //anim2.SetBool("DFA2S1",true);
                                cursor++;
                                goto case 2;
                            }
                            else
                            {
                                //Debug.Log("Invalid 1");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 1 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 2:
                        Debug.Log("State 3");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                //StartCoroutine(DelayAnimation(3,anim3,"DFA3S1",5));
                                //anim3.SetBool("DFA3S1",true);
                                cursor++;
                                goto case 3;
                            }
                            else
                            {
                                //Debug.Log("Invalid 2");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 2 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 3:
                        Debug.Log("State 4");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                //StartCoroutine(DelayAnimation(4,anim4,"DFA4S1",6));
                                cursor++;
                                goto case 4;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                //StartCoroutine(DelayAnimation(4,anim4,"DFA4S1",6));
                                cursor++;
                                goto case 5;
                            }
                            else
                            {
                                //Debug.Log("Invalid 3");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 3 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 4:
                        Debug.Log("State 5");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                //StartCoroutine(DelayAnimation(5,anim5,"DFA5S1",7));
                                cursor++;
                                goto case 6;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                //StartCoroutine(DelayAnimation(5,anim5,"DFA5S1",7));
                                cursor++;
                                goto case 5;
                            }
                            else
                            {
                                //Debug.Log("Invalid 4");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 4 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 5:
                        Debug.Log("State 6");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                //StartCoroutine(DelayAnimation(6,anim6,"DFA6S1",8));
                                cursor++;
                                goto case 4;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                //StartCoroutine(DelayAnimation(6,anim6,"DFA6S1",8));
                                cursor++;
                                goto case 6;
                            }
                            else
                            {
                                //Debug.Log("Invalid 5");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 5 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 6:
                        Debug.Log("State 7");
                        cursor--;
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                //StartCoroutine(DelayAnimation(7,anim7,"DFA7S1",9));
                                cursor++;
                                goto case 7;
                            }
                            else
                            {
                                //Debug.Log("Invalid 6");
                                ValidityCheck.text = "Invalid";
                                
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 6 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 7:
                        Debug.Log("State 8");
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                //StartCoroutine(DelayAnimation(8,anim8,"DFA8S1",10));
                                cursor++;
                                goto case 7;
                            }
                            else
                            {
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else if (cursor == user_input.Length - 1)
                        {
                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                ValidityCheck.text = "Valid";
                                Debug.Log("Cursor: " + cursor);
                                //Debug.Log("Valid");
                                return;
                            }
                            else
                            {
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        break;
                    default:
                        //Debug.Log("Invalid End");
                        ValidityCheck.text = "Invalid End";
                        break;
                }
            }
        } 
        else
        {
            Debug.Log("Please Click On a Toggle");
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
               
             switch (cursor)
             {
                 case 0:
                    Debug.Log("Initial State");
                    Debug.Log("Cursor: " + cursor);
                    Debug.Log("User Input Length " + user_input.Length);
                     if (cursor < user_input.Length)
                     {
                          if (user_input[cursor] == '0')
                            {
                                //StartCoroutine(DelayAnimation(1,Animate,"DFA1S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 1;
                            }
                            if (user_input[cursor] == '1')
                            {
                                //StartCoroutine(DelayAnimation(1,Animate,"DFA1S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 2;
                            }
                            else
                            {
                                Debug.Log("Invalid 0");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 0 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 1:
                        Debug.Log("State 2");
                        Debug.Log("Cursor: " + cursor);
                        Debug.Log("User Input Length " + user_input.Length);
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '0')
                            {
                                //StartCoroutine(DelayAnimation(2,Animate2,"DFA2S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 4;
                            }
                            if (user_input[cursor] == '1')
                            {
                                //StartCoroutine(DelayAnimation(2,Animate2,"DFA2S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 3;
                            }
                            else
                            {
                                //Debug.Log("Invalid 1");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 1 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 2:
                        Debug.Log("State 3");
                        Debug.Log("Cursor: " + cursor);
                        Debug.Log("User Input Length " + user_input.Length);
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '0' )
                            {
                                //StartCoroutine(DelayAnimation(3,Animate3,"DFA3S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 3;
                            }

                            if(user_input[cursor] == '1')
                            {
                                //StartCoroutine(DelayAnimation(3,Animate3,"DFA3S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 4; 
                            }

                            else
                            {
                                //Debug.Log("Invalid 2");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 2 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 3:
                        Debug.Log("State 4");
                        Debug.Log("Cursor: " + cursor);
                        Debug.Log("User Input Length " + user_input.Length);
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '0' || user_input[cursor] == '1')
                            {
                                //StartCoroutine(DelayAnimation(4,Animate4,"DFA4S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 4;
                            }
                            else
                            {
                                //Debug.Log("Invalid 3");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 3 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 4:
                        Debug.Log("State 5");
                        Debug.Log("Cursor: " + cursor);
                        Debug.Log("User Input Length " + user_input.Length);
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                //StartCoroutine(DelayAnimation(5,Animate5,"DFA5S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 5;
                            }
                            if (user_input[cursor] == '0')
                            {
                                //StartCoroutine(DelayAnimation(5,Animate5,"DFA5S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 6;
                            }
                            else
                            {
                                //Debug.Log("Invalid 4");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 4 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 5:
                        Debug.Log("State 6");
                        Debug.Log("User Input Length " + user_input.Length);
                        Debug.Log("Cursor: " + cursor);
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                //StartCoroutine(DelayAnimation(6,Animate6,"DFA6S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 7;
                            }
                            if (user_input[cursor] == '0')
                            {
                                //StartCoroutine(DelayAnimation(6,Animate6,"DFA6S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 6;
                            }
                            else
                            {
                                Debug.Log("Invalid 5");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            Debug.Log("Invalid 5 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 6:
                        Debug.Log("State 7");
                        Debug.Log("Cursor: " + cursor);
                        Debug.Log("User Input Length " + user_input.Length);
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                //StartCoroutine(DelayAnimation(7,Animate7,"DFA7S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 5;
                            }
                            if (user_input[cursor] == '0')
                            {
                                //StartCoroutine(DelayAnimation(7,Animate7,"DFA7S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                goto case 7;
                            }
                            else
                            {
                                Debug.Log("Invalid 6");
                                ValidityCheck.text = "Invalid";
                                
                                return;
                            }
                        }
                        else
                        {
                            Debug.Log("Invalid 6 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 7:
                        cursor--;
                        Debug.Log("State 8");
                        Debug.Log("User Input Length " + user_input.Length);
                        Debug.Log("Cursor: " + cursor);
                        if (cursor < user_input.Length- 1)
                        {

                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
                               //StartCoroutine(DelayAnimation(8,Animate8,"DFA8S2",FadeState));
                                cursor++;
                                goto case 8;

                            }
                            else
                            {
                                Debug.Log("Invalid 7");
                                ValidityCheck.text = "Invalid";
                                
                                return;
                            }
                        }
                        else
                             {
                                Debug.Log("Invalid 7 outside");
                                ValidityCheck.text = "Invalid";
                                return;
                             }

                    case 8:
                        Debug.Log("State 9");
                        Debug.Log("User Input Length " + user_input.Length);
                        Debug.Log("Cursor: " + cursor);
                        if (cursor < user_input.Length - 1)
                        {
                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
                                //StartCoroutine(DelayAnimation(9,Animate9,"DFA9S2",FadeState));
                                cursor++;
                                Debug.Log("Cursor: " + cursor);
                                ValidityCheck.text = "Valid";
                                goto case 8;
                              
                            }
                            else
                            {
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        if (cursor == user_input.Length - 1)
                        {
                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
                                Debug.Log("Cursor: " + cursor);
                                //Debug.Log("Valid");
                                ValidityCheck.text = "Valid";
                                return;
                            }
                            else
                            {
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                    break;
                    default:
                        //Debug.Log("Invalid End");
                        ValidityCheck.text = "Invalid End";
                        break;
                }
            }
        } 
        else
        {
            Debug.Log("Please Click On a Toggle");
        }
    }
     void Start()
     {
         //transition_state(user_input);
         detectToggle = GameObject.Find("ScriptHolder").GetComponent<DetectToggle>();
     }

}
