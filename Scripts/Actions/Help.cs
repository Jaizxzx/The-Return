using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Help")]
public class Help : Action
{
    public override void RespondToInput(GameController controller, string verb)
    {
        controller.currentText.text = "Type a Verb foolowed by a noun(e.g. \"go north\")";
        controller.currentText.text += "\nAllowed verbs:\nGo, Examine, Get, Give, Use, Read, Inventory, TalkTo,Say, Help";
    }
}
