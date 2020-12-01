using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    int selectedButton = 0;
    public List<GameObject> buttons = new List<GameObject>();
    public Color selected = new Color();
    public Color normal = new Color();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSelected(int index)
    {
        selectedButton = index;
        selectButton();
    }

    private void selectButton()
    {
        int i = 1;
        foreach(GameObject button in buttons)
        {
            Button b = button.GetComponent<Button>();
            if (i == selectedButton)
            {
                var bc = b.colors;
                bc.normalColor = selected;
                bc.selectedColor = selected;
                b.colors = bc;

            }
            else
            {
                var bc = b.colors;
                bc.normalColor = normal;
                b.colors = bc;
            }
            i++;
        }
    }
}
