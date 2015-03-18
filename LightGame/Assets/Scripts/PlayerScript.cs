using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class PlayerScript : MonoBehaviour {


	public GameObject rail;
	//up, down, RUP and RDown are indicators to whether the buttons that are represented by them, are pressed.
	public static bool up;
	public static bool down;
	public static bool RUp;
	public static bool RDown;


	void Update () {
		//Checks if any of the buttons are pressed and calls the method responsible for moving/rotating in specified direction
		if (up) 
		{
			MoveUp();
		}
		if (down) 
		{
			MoveDown();
		}
		if (RUp) 
		{
			RotateUp();
		}
		if (RDown) 
		{
			RotateDown();
		}	
	}


	public static void UpTrue()
	{
		up = true;
	}


	public static void UpFalse()
	{
		up = false;
	}


	public static void DownTrue()
	{
		down = true;
	}


	public static void DownFalse()
	{
		down = false;
	}


	public static void RUpTrue()
	{
		RUp = true;
	}


	public static void RUpFalse()
	{
		RUp = false;
	}


	public static void RDownTrue()
	{
		RDown = true;
	}


	public static void RDownFalse()
	{
		RDown = false;
	}


	//Moves shooter up, if shooter didnt reach upper rail's boundaries
	public  void MoveUp()
	{
		if (transform.position.y+ GetComponent<Renderer>().bounds.size.y/2.0f< rail.transform.position.y+rail.GetComponent<Renderer>().bounds.size.y/2.0f) 
		{
			transform.position = transform.position+new Vector3(0, 0.05f, 0);
		}
	}


	//Moves shooter down, if shooter didnt reach lower rail's boundaries
	public void MoveDown()
	{
		if (transform.position.y- GetComponent<Renderer>().bounds.size.y/2.0f> rail.transform.position.y+rail.GetComponent<Renderer>().bounds.size.y/-2.0f) 
		{
			transform.position = transform.position-new Vector3(0, 0.05f, 0);
		}
	}

	//Rotates shooter cw, if limit wasn't reached
	public void RotateUp()
	{
		float zz = transform.eulerAngles.z;
		print (zz+ " Up");
		if ((zz < 60 || zz >=300)) 
		{
			transform.Rotate (new Vector3(0,0,0.5f));
		}
		
	}

	//Rotates shooter ccw, if limit wasn't reached
	public void RotateDown()
	{
		float zz = transform.eulerAngles.z;
		print (zz+" Down");
		if ((zz<=61 || zz > 301)) 
		{
			transform.Rotate (new Vector3 (0, 0, -0.5f));
		}
	}
	
}
