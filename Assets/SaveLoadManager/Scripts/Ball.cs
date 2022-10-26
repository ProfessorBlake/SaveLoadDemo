using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody Rb;

	private SaveData data;

	private void Start()
	{
		Rb.AddForce(Random.insideUnitSphere * 1000);
		Rb.AddTorque(Random.insideUnitSphere * 100);
	}

	private void OnApplicationQuit()
	{
		data = new SaveData();
		data.Position = Rb.position;
		data.Velocity = Rb.velocity;
		data.AngularVelocity = Rb.angularVelocity;
		string dataAsJSON = JsonUtility.ToJson(data,true);
		Debug.Log(dataAsJSON);
	}
}
