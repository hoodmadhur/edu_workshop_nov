using System;
using UnityEngine;


[Serializable]
public class QuestionInfo : ScriptableObject
{
	public string QuestionText;

	public int CorrectOption;

	public bool CheckAnswer ( int selectedOption )
	{
		return selectedOption == CorrectOption;
	}

}






