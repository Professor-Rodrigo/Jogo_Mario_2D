using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collect_system : MonoBehaviour
{
   
    [SerializeField] private int score;

    [SerializeField] private TMP_Text txt_score;

    


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Coin")
        {
            Change_Score(10);
            Destroy(col.gameObject);
        }
    }


    void Change_Score(int _amount)
    {
        score += _amount;
        txt_score.text = "Score: " + score;

    }
   
}
