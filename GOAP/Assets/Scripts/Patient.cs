using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : GAgent
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        Subgoal s1 = new Subgoal(new Dictionary<string, int>() { { "isWaiting", 1 } }, true);
        goals.Add(s1, 3);
    }
}
