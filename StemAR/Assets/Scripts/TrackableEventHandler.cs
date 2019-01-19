using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackableEventHandler : DefaultTrackableEventHandler
{
   protected override void OnTrackingLost()
    {
        GameObject.FindObjectOfType<ObjManager>().TurnOff();
        base.OnTrackingLost();
        GameObject.Find("TargetOrAnimationUI").GetComponent<ShowFindTargetUI>().ShowFindTargetBg();

    }
    protected override void OnTrackingFound() {
        base.OnTrackingFound();
        GameObject.Find("TargetOrAnimationUI").GetComponent<ShowFindTargetUI>().HideFindTargetBg();
    }
}
