using UnityEngine;
using System.Collections;


public class UpMove : MonoBehaviour {

	
	void Update()
	{
		//during the 1st 5 secs the halo around the up button is on
		//then it is disabled on the 5th second
		if (Time.realtimeSinceStartup > 5.0f) 
		{
			Component halo = GetComponent ("Halo"); 
			halo.GetType ().GetProperty ("enabled").SetValue (halo, false, null);
		} 
		else 
		{
			Component halo = GetComponent ("Halo"); 
			halo.GetType ().GetProperty ("enabled").SetValue (halo, true, null);
		}
	}
	
	public void OnMouseDown() 
	{
		PlayerScript.UpTrue();
	}


	public void OnMouseUp()
	{
		PlayerScript.UpFalse ();
	}
}
