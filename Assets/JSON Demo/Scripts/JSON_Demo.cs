using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSON_Demo : MonoBehaviour
{
    public Player PlayerInstance;

	private void Start()
	{
		string playerAsJSON = JsonUtility.ToJson(PlayerInstance, true);

		Debug.Log(playerAsJSON);
	}
}
