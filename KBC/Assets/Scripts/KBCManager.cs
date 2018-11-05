using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KBCManager : MonoBehaviour {

	public static KBCManager instance = null;

	public QuizCollection quiz;

	public QuestionHandler TextQuestion;
	public QuestionImageHandler ImageQuestion;


	[SerializeField]
	int currentQuestion = -1;

	int maxQuestions;

	[SerializeField]
	int PointsToGive = 5;

	[SerializeField]
	int AwardedPoints = 0;



	private void Awake ()
	{
		if( instance == null )
			instance = this;
		else
		{
			Debug.LogError ( "KBCManager :: There are multiple KBC Manager present in scene, First instance is:" + instance.name );
			Debug.LogError ( "KBCManager :: deleting this one :" + name );
		}

	}

	// Use this for initialization
	void Start ()
	{
		currentQuestion = -1;
		

		FirstQuestion ( );
	}
	
	void FirstQuestion()
	{
		currentQuestion = 0;
		AwardedPoints = 0;
		maxQuestions = quiz.m_Questions.Count;
		resultsUI.SetActive ( false );
		UpdateQuestionInUI ( );
	}

	void UpdateQuestionInUI()
	{
		QuestionInfo q = quiz.GetQuestion( currentQuestion );
		ImageQuestion.gameObject.SetActive ( false );
		TextQuestion.gameObject.SetActive ( false );

		if ( q is QuestionText )
		{
			Debug.Log ( "KBCManager::Question is Text " + q  );
			TextQuestion.m_QuestionObject = q as QuestionText;
			TextQuestion.UpdateQuestion ( );
			TextQuestion.gameObject.SetActive (true );
		}
		else if ( q is QuestionImage )
		{
			Debug.Log ( "KBCManager::Question is Image " + q );

			ImageQuestion.m_QuestionObject = q as QuestionImage;
			ImageQuestion.UpdateQuestion ( );
			ImageQuestion.gameObject.SetActive ( true );

		}

	}

	internal void NextQuestion ( bool isCorrect )
	{
		currentQuestion++;

		if( isCorrect)
		{
			AwardedPoints += PointsToGive;
		}


		if ( currentQuestion < maxQuestions )
		{
			UpdateQuestionInUI ( );
		}
		else
		{
			ImageQuestion.gameObject.SetActive ( false );
			TextQuestion.gameObject.SetActive ( false );

			// show reward screen
			pointsUI.text = AwardedPoints.ToString ( );
			resultsUI.SetActive ( true );
		}

	}

	[SerializeField]
	Text    pointsUI;

	[SerializeField]
	GameObject  resultsUI;

}
