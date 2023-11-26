using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Event_Manager : MonoBehaviour
{
    public delegate void interactAction ( );
    public delegate void interactableClose ( );
    public static event interactAction onInteract;
    public static event interactableClose closeInteractObject; 

    private void Update ( ) {
        if ( Input.GetKeyDown ( KeyCode.F ) ) {
            if ( onInteract != null ) {
                onInteract ( );
            }
        } else if ( Input.GetKeyDown ( KeyCode.Escape ) ) {
            if ( closeInteractObject != null ) {
                closeInteractObject ( );
            }
        }
    }
}
