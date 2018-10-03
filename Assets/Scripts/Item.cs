using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public string Name;
    public float Value;
    public float Weight;

    public AudioSource Nom;

    public void Start()
    {
        Nom = GetComponent<AudioSource>();
    }


    public override string ToString()
    {
        return "Name: " + Name + "Price: "+ Value + "Kg:" + Weight;
    }

    private void OnMouseEnter()
    {
        Debug.Log(ToString());
        Nom.Play();
    }

    public float GetPricePerWeight()
    {
        return Value / Weight;
    }
}
