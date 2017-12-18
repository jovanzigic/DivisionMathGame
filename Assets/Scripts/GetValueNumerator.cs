using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GetValueNumerator : MonoBehaviour {
	[SerializeField] Text inputValue;
	[SerializeField] Text outputValue;


	public void displayNumber (){
		string numberString = inputValue.text.ToString();
		int numberInt = 0;
		int.TryParse (numberString, out numberInt);

		outputValue.text = numberInt.ToString ();
	}
}
