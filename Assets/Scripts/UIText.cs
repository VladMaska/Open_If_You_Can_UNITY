using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NaughtyAttributes;

public class UIText : MonoBehaviour {

    [TextArea]
    public string all_keys;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Text text;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    void Start(){

        text = GetComponent<Text>();       

    }

    void Update(){

        string path = Application.dataPath + "/keys.txt";

        StreamReader reader = new StreamReader( path );

        text.text = reader.ReadToEnd();
        all_keys = reader.ReadToEnd();

        reader.Close();

    }
    
}