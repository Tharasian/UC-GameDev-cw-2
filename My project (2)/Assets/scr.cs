using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class scr : MonoBehaviour
{
    int inc = 1;
    int score = 0;
    string points = "";
    public Text Points;


    public void Click ()
    {
        score = inc + score;
        Points.text = score + "";
        print("your score is" + score);

    }
    public void shopup() {
        if (score >= 50)
        {
            inc += 1;
            score -= 50;
            Points.text = score + "";
        }
    }
}
