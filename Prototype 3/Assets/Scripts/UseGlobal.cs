using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGlobal : MonoBehaviour
{
    public Global global;

    private void Awake()
    {
        global = GameObject.Find("GlobalManager").GetComponent<Global>();
    }
}
