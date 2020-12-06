using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject go;
    private GameObject selectedAvatar;
    public GameObject ARParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setAvatar(GameObject avatar)
    {
        selectedAvatar = avatar;
    }

    public void switchToScene(GameObject scene)
    {
        foreach (Transform child in go.transform)
        {
            child.gameObject.SetActive(false);
        }
        selectedAvatar.SetActive(true);
        selectedAvatar.transform.localScale = new Vector3((float)0.1, (float)0.1, (float)0.1);
        selectedAvatar.transform.parent = ARParent.transform;
        Vector3 pos = new Vector3(0, (float)-0.22, (float)0.43);
        selectedAvatar.transform.position = pos;
        scene.GetComponent<ARTrackedImageManager>().enabled = true;
    }
}
