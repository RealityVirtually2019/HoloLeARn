using UnityEngine;
using System.Collections;

public partial class Wit3D : MonoBehaviour {

	// A more generic function that takes an array of strings and returns an array of GameObjects

	GameObject[] GenericFindObjects(string[] objectsToFind) {

		print ("GENERIC FIND OBJECTS function called");

		// Create a GameObject array, the same size as our objectsToFind array
		GameObject[] gameObjectsArray = new GameObject[objectsToFind.Length];

		for (int i = 0; i < objectsToFind.Length; i++) {

			//debug 
			print("Loop #" + i);
			print ("Object to find: " + objectsToFind[i]);

			// if it can be found, add it to the array of GameObjects
			if (GameObject.Find (objectsToFind[i]) != null) {
				print("Trying to find " + objectsToFind [i]);
				gameObjectsArray[i] = GameObject.Find (objectsToFind [i]);
			}

			// otherwise, let us know
			else {
				print ("Couldn't find " + objectsToFind [i]);
			}

		}

		return gameObjectsArray;

	}
}
