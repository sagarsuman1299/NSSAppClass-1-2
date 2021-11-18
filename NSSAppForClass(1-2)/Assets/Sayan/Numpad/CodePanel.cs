using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour {

	public Text codeText;

    private void Start()
    {
		codeText.text = "";
    }


	public void AddDigit(string digit)
	{
		codeText.text += digit;
	}

}
