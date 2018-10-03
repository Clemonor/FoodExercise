using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Consumable {

    public float saturation;
    public bool isYummy;

    

    public override string UseText()
    {
        return base.UseText() ;
    }

    public override string ToString()
    {
        return base.ToString() + YummyToString();
    }

    public string YummyToString()
    {
        if(isYummy == true)
        {
            return " It was yummy.";
        }
        else
        {
            return " It was not yummy.";
        }
    }
}
