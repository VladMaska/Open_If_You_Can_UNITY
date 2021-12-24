using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

public class TestScript : MonoBehaviour {

    [HorizontalLine]

    [BoxGroup("Settings")]
    public string _name;

    [BoxGroup("Settings")]
    public GameObject text_obj;

    [BoxGroup("Settings")]
    public Color color;

    [Button("Button Text")]
    void Info(){ Debug.Log( l.LoadDataInt( _name ) ); }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    TextMesh text;
    bool open = false;
    Animator anim;
    bool key;

    Library l = new Library();

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        print( _name );
        anim = this.gameObject.GetComponent<Animator>();
        text = text_obj.GetComponent<TextMesh>();

        text.color = new Color( color.r, color.g, color.b );
        text.text = _name;

    }

    void Update(){

        Core();

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Open(){ anim.Play( "Open" ); open = true; }
    void Close(){ anim.Play( "Close" ); open = false; }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Core(){
        if ( l.LoadDataInt( _name ) == 1 ) key = true;
        else key = false;
    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void OnCollisionStay( Collision collision ){

        if ( collision.gameObject.tag == "Player" && key ){

            print( "true" );

            if ( Input.GetKeyDown( KeyCode.E ) && !open ) Open();
            else if ( Input.GetKeyDown( KeyCode.E ) && open ) Close();

        }
        
    }

}