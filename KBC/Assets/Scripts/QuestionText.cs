using System;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu ( fileName = "Q-" , menuName = "Quiz/TextQuestion" )]
[Serializable]
public class QuestionText : QuestionInfo
{
	public string OptionA;
	public string OptionB;
	public string OptionC;
	public string OptionD;


	//public List< string> Options = new List<string>();
	//public  void AddOption()
	//{
	//	Options.Add ( string.Empty );
	//}

}
