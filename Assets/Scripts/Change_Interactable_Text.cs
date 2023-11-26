using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Change_Interactable_Text : MonoBehaviour {
    public TMP_Text interactable_text;
    public Canvas base_canvas;
    public GameObject player;

    private GameObject closest_interactable;

    private void OnEnable ( ) {
        base_canvas.enabled = false;
        Interact_Event_Manager.onInteract += changeText;
        Interact_Event_Manager.closeInteractObject += closeCanvas;
    }

    private void OnDisable ( ) {
        Interact_Event_Manager.onInteract -= changeText;
        Interact_Event_Manager.closeInteractObject -= closeCanvas;
    }

    void changeText ( ) {
        closest_interactable = getNearest ( );
        if ( Vector3.Distance ( player.gameObject.transform.position, closest_interactable.gameObject.transform.position ) < 3 ) {
            base_canvas.enabled = true;
            interactable_text.text = closest_interactable.GetComponent<StoredText> ( ).text;
        }

        //interactable_text.text = 
    }

    GameObject getNearest ( ) {
        GameObject closest = null;
        float dist, old_dist = 9999f;
        foreach ( GameObject g in GameObject.FindGameObjectsWithTag ( "Sign_Post" ) ) {
            dist = Vector3.Distance ( player.gameObject.transform.position, g.gameObject.transform.position );
            if ( dist < old_dist ) {
                old_dist = dist;
                closest = g;
            }
        }
        return closest;
    }

    void closeCanvas ( ) {
        base_canvas.enabled = false;
        if ( closest_interactable.GetComponent<StoredText> ( ).final_clue ) {
            SceneManager.LoadScene ( "End_Screen" );
        }
    }
}
