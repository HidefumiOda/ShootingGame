using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyScoreManager : MonoBehaviour
{
    public static int score;
    TextMeshProUGUI text;

    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    void Update()
    {
        text.text = "score : " + score;
    }
}
