using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

public class WorldCore : MonoBehaviour {

    [ReorderableList]
    public GameObject[] obj;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/



    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        for ( int i=1; i<obj.Length; i++ ){ obj[ i ].SetActive( false ); }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/



    }

    void Update(){
    
        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
}