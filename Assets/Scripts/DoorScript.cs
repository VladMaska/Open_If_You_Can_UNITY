using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

public class DoorScript : MonoBehaviour {

    [BoxGroup("Settings")]
    public string _name;
    [HorizontalLine]
    [BoxGroup("Settings")]
    public GameObject text_obj;
    [BoxGroup("Settings")]
    public Color color;
    [BoxGroup("Settings")]
    public string str;
    [BoxGroup("Settings")]
    public bool open = false;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    TextMesh text;

    Library l;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        this.gameObject.transform.eulerAngles = new Vector3( -90, 0, 0 );

        this.gameObject.name = _name;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        text = text_obj.GetComponent<TextMesh>();

    }

    void Update(){

        text.color = new Color( color.r, color.g, color.b );
        text.text = str;
    
        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        if ( open ) this.gameObject.transform.eulerAngles = new Vector3( transform.eulerAngles.x, transform.eulerAngles.y, 90 );
        else this.gameObject.transform.eulerAngles = new Vector3( transform.eulerAngles.x, transform.eulerAngles.y, 0 );

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void OnCollisionEnter( Collision collision ){

        if ( Input.GetKeyDown( KeyCode.E ) && collision.gameObject.tag == "player" ){

            l.SaveDataInt( this.gameObject.name, 0 );

            if ( l.LoadDataInt( this.gameObject.name ) == 1 && !open ) open = true;
            else if ( l.LoadDataInt( this.gameObject.name ) == 1 && !open ) open = false;

        }
        
    }

}