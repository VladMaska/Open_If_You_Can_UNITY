using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Library : MonoBehaviour {

    // Load INT
    public int LoadDataInt( string name ){

        if ( PlayerPrefs.HasKey( name ) ){ 

            return PlayerPrefs.GetInt( name );

        }
        else {

            return -1;

        }

    }

    // Load STRING
    public string LoadDataString( string name ){

        if ( PlayerPrefs.HasKey( name ) ){

            return PlayerPrefs.GetString( name );

        }
        else {

            return null;

        }

    }

    // Load FLOAT
    public float LoadDataFloat( string name ){

        if ( PlayerPrefs.HasKey( name ) ){

            return PlayerPrefs.GetFloat( name );

        }
        else {

            return -1;

        }

    }

    // Save INT
    public void SaveDataInt( string name, int value ){

        PlayerPrefs.SetInt( name, value );
        PlayerPrefs.Save();

        Debug.Log( "Game data saved! TYPE: INT | NAME: " + name );

    }

    // Save STRING
    public void SaveDataString( string name, string value ){

        PlayerPrefs.SetString( name, value );
        PlayerPrefs.Save();

        Debug.Log("Game data saved! TYPE: STRING | NAME: " + name );

    }

    // Save FLOAT
    public void SaveDataFloat( string name, float value ){

        PlayerPrefs.SetFloat( name, value );
        PlayerPrefs.Save();

        Debug.Log( "Game data saved! TYPE: FLOAT | NAME: " + name );

    }

    // Reset ALL
    public void ResetData(){

        PlayerPrefs.DeleteAll();
        Debug.Log( "Data reset complete! ALL!!!" );

    }
    
}