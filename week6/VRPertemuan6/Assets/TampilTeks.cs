using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TampilTeks : MonoBehaviour
{
    public Text week3,week4,week5;

    // Start is called before the first frame update
    void Start()
    {
        week3.enabled = false;
        week4.enabled = false;
        week5.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void week3On()
    {
        week3.enabled = true;
    }
    public void week3Off()
    {
        week3.enabled = false;
    }
    public void week4On()
    {
        week4.enabled = true;
    }
    public void week4Off()
    {
        week4.enabled = false;
    }
    public void week5On()
    {
        week5.enabled = true;
    }
    public void week5Off()
    {
        week5.enabled = false;
    }
}
