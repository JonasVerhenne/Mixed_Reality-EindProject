using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        gameObject.GetComponent<Canvas>().worldCamera = Camera.main;
        Debug.Log("Camera updated for" + gameObject.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
