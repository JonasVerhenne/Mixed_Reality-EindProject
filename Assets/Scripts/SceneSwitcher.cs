using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
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
        foreach(GameObject go in objects)
        {
            go.SetActive(false);
        }
        scene.SetActive(true);
    }
}
