using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackableEventHandler : DefaultTrackableEventHandler
{
   protected override void OnTrackingLost()
    {
        GameObject.FindObjectOfType<ObjManager>().TurnOff();
        base.OnTrackingLost();
    }
}
