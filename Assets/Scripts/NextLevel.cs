using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

public class NextLevel : MonoBehaviour {

    /* PUBLIC */

    [Scene]
    public int scene;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    /* LOCAL */



    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void OnCollisionEnter( Collision collision ){

        if ( collision.gameObject.tag == "Player" ) SceneManager.LoadScene( scene );
        
    }

    private void OnTriggerEnter( Collider other ){

        if ( other.gameObject.tag == "Player" ) SceneManager.LoadScene( scene );
        
    }

}