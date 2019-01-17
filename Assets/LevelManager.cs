using UnityEngine;
using System.Collections;


public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("Level load requested"+name);
		Application.LoadLevel (name);

	}
	public void QuitRequest(string quit){
		
		Debug.Log ("Level Quit requested"+quit);
		Application.Quit ();
	}
}
