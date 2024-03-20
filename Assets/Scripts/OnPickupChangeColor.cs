using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPickupChangeColor : MonoBehaviour
{
    private Material materialToChange;

    private void Start()
    {
        materialToChange = GetComponent<Renderer>().material;
    }
    
}
