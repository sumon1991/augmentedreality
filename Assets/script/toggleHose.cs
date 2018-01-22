using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleHose : MonoBehaviour {
    

    Toggle m_Toggle;
    public Text m_Text ;

    void Start()
    {
        //Fetch the Toggle GameObject
        m_Toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, and output the state
        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });

        //Initialize the Text to say whether the Toggle is in a positive or negative state
        m_Text.text = "Toggle is : " + m_Toggle.isOn;
    }
    void ToggleValueChanged(Toggle change)
    {
        m_Text.text = "Toggle is : " + m_Toggle.isOn;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
