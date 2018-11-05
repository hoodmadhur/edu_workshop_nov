using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu ( fileName = "QuizCollection-" , menuName = "Quiz/QuizCollection" , order = 0 )]
public class QuizCollection : ScriptableObject
{
	public List< QuestionInfo > m_Questions = new List<QuestionInfo>();

	public void AddOption ()
	{
		m_Questions.Add ( null );
	}

	public QuestionInfo GetQuestion ( int index)
	{
		if( index >= 0 && index < m_Questions.Count)
			return m_Questions[index];

		Debug.LogWarning ( "QuizCollection : invalid question number :" + index + " when total number of questions is " + m_Questions.Count + "  :: Returning first question as backup" );
		return m_Questions[0];
	}


}
