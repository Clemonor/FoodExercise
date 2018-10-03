using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{

    public float uses;
    public float maxuses;

    public virtual string UseText()
    {
        return " You ate the " + Name + " It has uses: " + uses + " remaning";
    }

    public virtual string NoUsesRemaningText()
    {
        return "Cant use " + Name;
    }

    public override string ToString()
    {
        return " Name: " + Name + 
            " Price: " + Value + 
            " Kg: " + Weight + 
            " You have: " + uses +
            " You can have max: " + maxuses;
    }

    private void OnMouseUpAsButton()
    {
        Consume();
    }

    public virtual void  Consume()
    {
        if (uses > 0)
        {
            uses = uses - 1;
            print(UseText());
            
        }
        
        if (uses == 0)
        {
            Destroy(gameObject);
            print(NoUsesRemaningText());
        }
           
    }
}
