using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionImageHandler : MonoBehaviour {

	public QuestionImage    m_QuestionObject;

	public Text m_Question;

	public Image m_OptionA;
	public Image m_OptionB;
	public Image m_OptionC;
	public Image m_OptionD;


	void Start ()
	{
		UpdateQuestion ( );
	}

	internal void UpdateQuestion ()
	{
		m_Question.text = m_QuestionObject.QuestionText;
		m_OptionA.sprite = m_QuestionObject.OptionA;
		m_OptionB.sprite = m_QuestionObject.OptionB;
		m_OptionC.sprite = m_QuestionObject.OptionC;
		m_OptionD.sprite = m_QuestionObject.OptionD;
		IsCorrect = false;
	}

	bool IsCorrect;

	public void SelectedOptionA ()
	{
		IsCorrect = m_QuestionObject.CheckAnswer ( 1 );

		KBCManager.instance.NextQuestion ( IsCorrect );

	}

	public void SelectedOptionB ()
	{
		IsCorrect = m_QuestionObject.CheckAnswer ( 2 );

		KBCManager.instance.NextQuestion ( IsCorrect );
	}

	public void SelectedOptionC ()
	{
		IsCorrect = m_QuestionObject.CheckAnswer ( 3 );

		KBCManager.instance.NextQuestion ( IsCorrect );
	}

	public void SelectedOptionD ()
	{
		IsCorrect = m_QuestionObject.CheckAnswer ( 4 );

		KBCManager.instance.NextQuestion ( IsCorrect );
	}



}
