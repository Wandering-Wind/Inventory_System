using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScalingIssue : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //I have an issue whereby when I click on my items, in order to instantiate it
        //to the lil square where the moving happens
        //The clone scales to like a 100

        Transform prefabTransform = GetComponent<Transform>();
        prefabTransform.localScale = Vector3.one;
    }
}
