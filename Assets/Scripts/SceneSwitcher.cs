﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchToScene(GameObject scene)
    {
        go.SetActive(false);
        scene.GetComponent<ARTrackedImageManager>().enabled = true;
    }
    public void closeScene(GameObject scene)
    {
        scene.SetActive(false);
    }
}
