using UnityEngine;
using TMPro;


public class TextTest : MonoBehaviour
{
    public TMP_Text text1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            text1.text = "Player Controls Enabled";
        }

        
    }
}
