using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarna : MonoBehaviour
{
    public void Merah()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    
    public void Biru()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    
    public void Hitam()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
    
    public void Hijau()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    
    public void Kuning()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    
    public void Abuabu()
    {
        GetComponent<Renderer>().material.color = Color.grey;
    }
    
    public void Toska()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }
    
    public void Ungu()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }
    
    public void Putih()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
