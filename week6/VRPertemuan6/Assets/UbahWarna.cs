using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarna : MonoBehaviour
{
    public void Abu()
    {
        GetComponent<Renderer>().material.color = Color.gray;
    }
    public void Toska()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }
    public void Merah()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
