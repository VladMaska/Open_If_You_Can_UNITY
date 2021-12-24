using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

public class main : MonoBehaviour {

    [ShowAssetPreview]
    public GameObject door;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public Vector3 xyz;
    GameObject obj;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    void Start(){

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/        

        for ( int i=0; i<10; i++ ){

            obj = Instantiate( door, new Vector3( xyz.x, xyz.y, xyz.z ), Quaternion.identity );
            obj.name = "I LOVE YOU";
            obj.transform.eulerAngles = new Vector3( -90, 0, 90 );

            xyz = new Vector3( xyz.x, xyz.y, xyz.z - 2 );

        }

    }

    void Update(){
    
        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
}