using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_panel : MonoBehaviour
{
    public List<GameObject> panels;

    // Start is called before the first frame update
    void Start()
    {
        print("start");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        //Destroy(gameObject);
    }

    public void HideMainPanel()
    {
        gameObject.SetActive(false);
    }

    public void ShowMainPanel()
    {
        gameObject.SetActive(true);
    }
}
