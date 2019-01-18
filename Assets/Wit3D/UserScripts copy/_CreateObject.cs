using UnityEngine;
using System.Collections;
using SimpleJSON;

public partial class Wit3D : MonoBehaviour {

	void CreateObjectHandler(string textToParse){

		// Debug: print
		print ("CREATE OBJECT function called");

		// Parse JSON
		var N = JSON.Parse (textToParse);

		// Find the entities: subject, destination, and new_name
		string subjJson = N["outcomes"][0]["entities"]["subject"][0]["value"].Value.ToLower();
		string newNameJson = N["outcomes"][0]["entities"]["new_name"][0]["value"].Value.ToLower();
		string destJson = N["outcomes"][0]["entities"]["destination"][0]["value"].Value.ToLower();
		int qtyJson = N ["outcomes"] [0] ["entities"] ["number"] [0] ["value"].AsInt;

		// State machine:

		// All should have at least a subject
		GameObject subject = GameObject.Find(subjJson);

		if (qtyJson == 0 || qtyJson == null) {

			print ("No quantity");
			qtyJson = 1;

		}

		// if no name:
		if (newNameJson == "") {
			// the new object will just have the name as the original object
			newNameJson = subject.name;
		}

		// if a destination is specified
		if (destJson == "") {

			print ("No destination - just the subject");
			StartCoroutine(CreateObject (subject, spawnPoint, newNameJson, qtyJson));

		} else {

			GameObject destination = GameObject.Find (destJson);
			print ("Destination: " + destJson);

			StartCoroutine(CreateObject (subject, destination, newNameJson, qtyJson));

		}

	}

	// Coroutine: Instantiate an object at point
	IEnumerator CreateObject(GameObject subject, GameObject destination, string new_name, int qty)
	{
		// Debug: print ("Instantiate function called, qty = " + qty);
		for (int i = 0; i < qty; i++) {
			Vector3 instantiationPoint = destination.transform.position + new Vector3 (0, yOffset, 0);
			Instantiate (subject, instantiationPoint, default(Quaternion)).name = new_name;
		}
		yield return null;

	}

}
