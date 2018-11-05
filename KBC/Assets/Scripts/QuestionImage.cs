using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[CreateAssetMenu ( fileName = "Q-" , menuName = "Quiz/TextImage" )]
public class QuestionImage : QuestionInfo
{
	//public List< Image > Options = new List<Image>();
	public Sprite OptionA;
	public Sprite OptionB;
	public Sprite OptionC;
	public Sprite OptionD;


	//public void AddOption ()
	//{
	//	Options.Add ( null );
	//}


}


