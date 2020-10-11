using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
      public Image imgGaze;
    public Text RedBox;
    public Text BlackBox;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    // Start is called before the first frame update
    void Start()
    {
        RedBox.enabled = false;
        BlackBox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        if(gameObject.tag == "Red")
        {

        }
    }

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }

    public void mouseoverRedBoxOn()
    {
        RedBox.enabled = true;
    }

    public void mouseoverRedBoxOff()
    {
        RedBox.enabled = false;
    }

    public void mouseoverBlackBox()
    {
        BlackBox.enabled = true;
    }

    public void mouseoverBlackBoxOff()
    {
        BlackBox.enabled = false;
    }
}