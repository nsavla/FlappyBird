﻿using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<Bird>() != null) 
		{
			GameController.instance.BirdScored ();
		}
		}

}
