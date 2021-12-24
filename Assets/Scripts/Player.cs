using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NaughtyAttributes;

public class Player : MonoBehaviour {

    [BoxGroup("Settings")]
    [Label("Show")]
    public bool show_s;

    [HorizontalLine]

    [ShowIf("show_s")]
    [BoxGroup("Settings")]
    [Range( 0, 10 )]
    public float speed = 10;

    [ShowIf("show_s")]
    [BoxGroup("Settings")]
    [Range(0, 10)]
    public float rotation = 5;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Library l = new Library();

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        transform.position = new Vector3( 0, 5, 0 );
        
    }

    void Update(){

        Mooving();
        Rotation();

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Mooving(){

        if ( Input.GetKey( KeyCode.W ) ) this.transform.Translate( Vector3.forward * Time.deltaTime * speed );
         
        if ( Input.GetKey( KeyCode.S ) ) this.transform.Translate( Vector3.back * Time.deltaTime * speed);

    }

    void Rotation(){

        if ( Input.GetKey( KeyCode.A ) ) this.transform.Rotate( Vector3.up, -rotation );
        
        if ( Input.GetKey( KeyCode.D ) ) this.transform.Rotate( Vector3.up, rotation );

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void OnCollisionEnter( Collision collision ){

        GameObject obj = collision.gameObject;

        if ( obj.tag == "key" ){

            l.SaveDataInt( obj.name, 1 );

            Destroy( obj );

        }
        
    }

}