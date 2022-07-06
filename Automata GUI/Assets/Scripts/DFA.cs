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
                                cursor++;
                                goto case 1;
                            }
                            else if (user_input[cursor] == 'b')
                            {
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
                            Debug.Log("Invalid 0 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 1:
                        Debug.Log("State 2");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                cursor++;
                                goto case 3;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                cursor++;
                                goto case 2;
                            }
                            else
                            {
                                Debug.Log("Invalid 1");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            Debug.Log("Invalid 1 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 2:
                        Debug.Log("State 3");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
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
                                cursor++;
                                goto case 4;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                cursor++;
                                goto case 5;
                            }
                            else
                            {
                                Debug.Log("Invalid 3");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            Debug.Log("Invalid 3 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 4:
                        Debug.Log("State 5");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                cursor++;
                                goto case 6;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                cursor++;
                                goto case 5;
                            }
                            else
                            {
                                Debug.Log("Invalid 4");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            Debug.Log("Invalid 4 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 5:
                        Debug.Log("State 6");
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == 'a')
                            {
                                cursor++;
                                goto case 4;
                            }
                            else if (user_input[cursor] == 'b')
                            {
                                cursor++;
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
                        cursor--;
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                cursor++;
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
                        Debug.Log("State 8");
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
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
                     if (cursor < user_input.Length)
                     {
                          if (user_input[cursor] == '0')
                            {
                                cursor++;
                                goto case 1;
                            }
                            if (user_input[cursor] == '1')
                            {
                                cursor++;
                                goto case 2;
                            }
                            else
                            {
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 1:
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '0')
                            {
                                cursor++;
                                goto case 4;
                            }
                            if (user_input[cursor] == '1')
                            {
                                cursor++;
                                goto case 3;
                            }
                            else
                            {
                                Debug.Log("Invalid 1");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            Debug.Log("Invalid 1 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 2:
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '0' )
                            {
                                cursor++;
                                goto case 3;
                            }

                            if(user_input[cursor] == '1')
                            {
                                cursor++;
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
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '0' || user_input[cursor] == '1')
                            {
                                cursor++;
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
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                cursor++;
                                goto case 5;
                            }
                            if (user_input[cursor] == '0')
                            {
                                cursor++;
                                goto case 6;
                            }
                            else
                            {
                                Debug.Log("Invalid 4");
                                ValidityCheck.text = "Invalid";
                                return;
                            }
                        }
                        else
                        {
                            Debug.Log("Invalid 4 outside");
                            ValidityCheck.text = "Invalid";
                            return;
                        }
                    case 5:
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                cursor++;
                                goto case 7;
                            }
                            if (user_input[cursor] == '0')
                            {
                                cursor++;
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
                        if (cursor < user_input.Length)
                        {

                            if (user_input[cursor] == '1')
                            {
                                cursor++;
                                goto case 5;
                            }
                            if (user_input[cursor] == '0')
                            {
                                cursor++;
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
                        if (cursor < user_input.Length- 1)
                        {

                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
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
                        if (cursor < user_input.Length - 1)
                        {
                            if (user_input[cursor] == '1' || user_input[cursor] == '0')
                            {
                                cursor++;
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
