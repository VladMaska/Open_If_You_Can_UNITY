using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Key : MonoBehaviour {

    public Material material;
    public string _name;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Library l = new Library();

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    void Start(){

        this.gameObject.name = _name;

        if ( l.LoadDataInt( this.gameObject.name ) == 1 ) Destroy( this.gameObject );
        else this.gameObject.GetComponent<Renderer>().material = material;

    }
    
}