using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text info;
    private float sayac;
    private Slider zaman;

    private void Awake()
    {
        info = GameObject.FindWithTag("info").GetComponent<Text>();
        zaman = GameObject.Find("Timer").GetComponent<Slider>();
    }

    void Start()
    {
        zaman.maxValue = 60;
        zaman.minValue = 0;
        zaman.wholeNumbers = false;
        zaman.value = zaman.maxValue;
        sayac= zaman.value;
    }

    // Update is called once per frame
    void Update()
    {
       if(zaman.value>zaman.minValue)
        {
            sayac -= Time.deltaTime;
            zaman.value = sayac;
            info.text =((int)zaman.value).ToString();
        }
       else
        {
            info.text = "Ýftar baþladý !!!";
        }
    }
}
