using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptManager : MonoBehaviour {

	public void Level1_loader()
	{
		SceneManager.LoadScene ("FirstScene");
	}
	public void Game_Exit()
	{
		Application.Quit ();
	}
}
