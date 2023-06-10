using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Register : GAction
{
    public override bool PrePerform()
    {
        //target = GWorld.Instance.GetQueue("patients").RemoveResource();
        //if (target == null)
        //{
        //    return false;
        //}
        //inventory.AddItem(target);
        //GWorld.Instance.GetWorld().ModifyState("FreeBed", -1);
        return true;
    }

    public override bool PostPerform()
    {
        //GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        //GWorld.Instance.GetWorld().ModifyState("FreeBed", 1);
        //beliefs.ModifyState("atHospital", 1);
        return true;
    }
}
