using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cottontracker : MonoBehaviour
{
    public static Cottontracker _instance;
    public TMPro.TextMeshProUGUI text;
    public int collected { get; private set; } = 0;
    public void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            text = GameObject.Find("COTTONTRACKER").GetComponent<TMPro.TextMeshProUGUI>();
        }
    }

    public void AddScore()
    {
        collected++;

        text.text = collected.ToString();
    }
}
