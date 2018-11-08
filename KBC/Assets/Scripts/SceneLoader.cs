using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	[SerializeField]    int     SceneToLoad;

	public void LoadScene()
	{
		SceneManager.LoadScene ( SceneToLoad );
	}

}
