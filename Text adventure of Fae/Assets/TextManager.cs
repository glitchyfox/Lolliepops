using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {

    public Text text;
    public Button trueButton;
    public Button falseButton;

    public bool option 1;
    public bool option 2;

    private enum States
    {
        question, trueState, falseState
    };

    private States mystate;

}

    // Use this for initialization
    void Start () {
    myStates = States.question;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onEnable() {
    trueButton.onClick.AddListener(delegate { Option1 = true;});
    falseButton.onClick.AddListener(delegate { Option2 = true; });

}

void question() { 
        text.text = "Ice is cold.";
    }

    if(option1 == true){myState = States.trueState;}
    else if(option2 == true){mystate = States.falseState;}
    }
}