using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

public class NewBehaviourScript : MonoBehaviour {

    Library l = new Library();

    [Button]
    void Main(){

        l.SaveDataInt( "01", -1 );
        l.SaveDataInt( "02", -1 );
        l.SaveDataInt( "03", -1 );

    }
    
}