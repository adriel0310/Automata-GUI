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
        if(detectToggle.Toggle1.isOn)
        {
            user_input = user_Input.text;
        
            int cursor = 0;
         foreach (char x in user_input)
            {
             switch (cursor)
             {
                 case 0:
                     Debug.Log("Initial State");
                     if (cursor < user_input.Length - 1)
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
                                ValidityCheck.text = "Invalid 0";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 0 outside");
                            ValidityCheck.text = "Invalid 0 outside";
                            return;
                        }
                    case 1:
                        Debug.Log("State 2");
                        if (cursor < user_input.Length - 1)
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
                                //Debug.Log("Invalid 1");
                                ValidityCheck.text = "Invalid 1";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 1 outside");
                            ValidityCheck.text = "Invalid 1 outside";
                            return;
                        }
                    case 2:
                        Debug.Log("State 3");
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                cursor++;
                                goto case 3;
                            }
                            else
                            {
                                //Debug.Log("Invalid 2");
                                ValidityCheck.text = "Invalid 2";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 2 outside");
                            ValidityCheck.text = "Invalid 2 outside";
                            return;
                        }
                    case 3:
                        Debug.Log("State 4");
                        if (cursor < user_input.Length - 1)
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
                                //Debug.Log("Invalid 3");
                                ValidityCheck.text = "Invalid 3";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 3 outside");
                            ValidityCheck.text = "Invalid 3 outside";
                            return;
                        }
                    case 4:
                        Debug.Log("State 5");
                        if (cursor < user_input.Length - 1)
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
                                //Debug.Log("Invalid 4");
                                ValidityCheck.text = "Invalid 4";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 4 outside");
                            ValidityCheck.text = "Invalid 4 outside";
                            return;
                        }
                    case 5:
                        Debug.Log("State 6");
                        if (cursor < user_input.Length - 1)
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
                                //Debug.Log("Invalid 5");
                                ValidityCheck.text = "Invalid 5";
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 5 outside");
                            ValidityCheck.text = "Invalid 5 outside";
                            return;
                        }
                    case 6:
                        Debug.Log("State 7");
                        if (cursor < user_input.Length - 1)
                        {

                            if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                            {
                                cursor++;
                                goto case 7;
                            }
                            else
                            {
                                //Debug.Log("Invalid 6");
                                ValidityCheck.text = "Invalid 6";
                                
                                return;
                            }
                        }
                        else
                        {
                            //Debug.Log("Invalid 6 outside");
                            ValidityCheck.text = "Invalid 6 outside";
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
                                ValidityCheck.text = "Invalid 7";
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
                                ValidityCheck.text = "Invalid 7";
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

    // Start is called before the first frame update
     void Start()
     {
         //transition_state(user_input);
         detectToggle = GameObject.Find("ScriptHolder").GetComponent<DetectToggle>();
     }
}
