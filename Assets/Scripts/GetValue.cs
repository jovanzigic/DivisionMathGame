using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GetValue : MonoBehaviour {
	[SerializeField] Text numerValue;
	[SerializeField] Text denomValue;
	[SerializeField] Text answerValue;


	public void displayNumber (){
		string numerString = numerValue.text.ToString();
		double numerDbl = 0;
		double.TryParse (numerString, out numerDbl);

		string denomString = denomValue.text.ToString();
		double denomDbl = 0;
		double.TryParse (denomString, out denomDbl);

		double answerDbl = numerDbl / denomDbl;
		if (double.IsNaN(answerDbl)) {
			answerValue.text = "Not a Number";
		} 
		else if (double.IsInfinity(answerDbl)) {
			answerValue.text = "Not a Real Number";
		}
		else if (answerDbl == 0) {
			answerValue.text = "No Value";
		}
		else {
			answerValue.text = answerDbl.ToString ();
		}
	}
}
