using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_check : MonoBehaviour
{
    private bool _is_in_ground;

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ground")
        {
            Debug.Log("detectou");
            _is_in_ground = true;
            Jump_State();
            
        }
    }

     void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "ground")
        {
            Debug.Log("saiu");

            _is_in_ground = false;
            Jump_State();
            
        }
    }

    public bool Jump_State()
    {
        return _is_in_ground;
    }
}
