using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFA_Incomplete : MonoBehaviour
{
    string user_input = "ba";

    void transition_state(string user_input)
    {
        int cursor = 0;
        foreach (char x in user_input)
        {
            switch (cursor)
            {
                case 0:
                    Debug.Log("Initial State");
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
                        break;
                    }
                case 1:
                    Debug.Log("State 2");
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
                        break;
                    }
                case 2:
                    Debug.Log("State 3");
                    if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                    {
                        cursor++;
                        goto case 3;
                    }
                    else
                    {
                        Debug.Log("Invalid 2");
                        break;
                    }
                case 3:
                    Debug.Log("State 4");
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
                        break;
                    }
                case 4:
                    Debug.Log("State 5");
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
                        break;
                    }
                case 5:
                    Debug.Log("State 6");
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
                        break;
                    }
                case 6:
                    Debug.Log("State 7");
                    if (user_input[cursor] == 'a' || user_input[cursor] == 'b')
                    {
                        cursor++;
                        goto case 7;
                    }
                    else
                    {
                        Debug.Log("Invalid 6");
                        break;
                    }
                case 7:
                    Debug.Log("State 8");
                    if (user_input[cursor] == 'a' || user_input[cursor] == 'b' && cursor < user_input.Length)
                    {
                        cursor++;
                        break;
                    }
                    else if (user_input[cursor] == 'a' || user_input[cursor] == 'b' && cursor >= user_input.Length)
                    {
                        Debug.Log("Valid");
                        break;
                    }
                    else
                    {
                        Debug.Log("Invalid 7");
                        break;
                    }
                default:
                    Debug.Log("Invalid End");
                    break;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        transition_state(user_input);
    }
}
