using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

 
public class ButtonHandler : MonoBehaviour
{
    public VirtualButtonBehaviour button;

    public Animator anim;
    bool buttonPressed=false;
    // Start is called before the first frame update
    void Start()
    {
        button.RegisterOnButtonPressed(OnButtonPressed);
    }
    private void Update()
    {
        if (buttonPressed)
        {
            anim.SetBool("buttonPressed", true);
        }else if (!buttonPressed)
        {
            anim.SetBool("buttonPressed", false);
        }
    }
    public void OnButtonPressed(VirtualButtonBehaviour button)
    {
        if (buttonPressed) { buttonPressed = false; } else { buttonPressed = true; }
        
        Debug.Log("Button was pressed!");
    }
}
