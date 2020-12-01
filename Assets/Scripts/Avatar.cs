using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{

    private bool isRotating = false;
    private int rotatedDegrees;
    private int selectedOption = 0;
    public List<GameObject> faces = new List<GameObject>();
    private int selectedFace = 0;
    public List<GameObject> hairs = new List<GameObject>();
    private int selectedHair = 0;
    public List<GameObject> eyes = new List<GameObject>();
    private int selectedEyes = 0;
    public List<GameObject> accessories = new List<GameObject>();
    private int selectedAccessory = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (isRotating)
        {
            gameObject.transform.Rotate(0, 2, 0);
            rotatedDegrees++;
        }
        if (rotatedDegrees == 180)
        {
            isRotating = false;
            rotatedDegrees = 0;
        }
    }

    public void selectOption(int index)
    {
        Debug.Log("option changed");
        selectedOption = index;
    }

    public void switchStyleObject()
    {
        switch (selectedOption)
        {
            case 0:
                Debug.Log("gezicht geselecteerd");
                selectedFace++;
                if (selectedFace == faces.Count)
                {
                    selectedFace = 0;
                }
                iterateList(faces, selectedFace);
                break;
            case 1:
                Debug.Log("haar geselecteerd");
                selectedHair++;
                if (selectedHair == hairs.Count)
                {
                    selectedHair = 0;
                }
                iterateList(hairs, selectedHair);
                break;
            case 2:
                Debug.Log("ogen geselecteerd");
                selectedEyes++;
                if (selectedEyes == eyes.Count)
                {
                    selectedEyes = 0;
                }
                iterateList(eyes, selectedEyes);
                break;
            case 3:
                Debug.Log("accessoire geselecteerd");
                selectedAccessory++;
                if (selectedAccessory == accessories.Count + 1)
                {
                    selectedAccessory = 0;
                }
                iterateList(accessories, selectedAccessory);
                break;
        }
    }

    private void iterateList(List<GameObject> go, int select)
    {
        int i = 0;
        foreach (GameObject g in go)
        {
            if (i == select)
            {
                g.SetActive(true);
            }
            else
            {
                g.SetActive(false);
            }
            i++;
        }
    }

    public void startRotating()
    {
        if (isRotating)
        {
            isRotating = false;
        }
        else
        {
            isRotating = true;
        }
    }
}
