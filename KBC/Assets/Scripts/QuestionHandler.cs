using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionHandler : MonoBehaviour {

	public QuestionText    m_QuestionObject;

	public Text m_Question;

	public Text m_OptionA;
	public Text m_OptionB;
	public Text m_OptionC;
	public Text m_OptionD;


	// Use this for initialization
	void Start ()
	{
		UpdateQuestion ( );
	}

	internal void UpdateQuestion ()
	{
		m_Question.text = m_QuestionObject.QuestionText;
		m_OptionA.text = m_QuestionObject.OptionA;
		m_OptionB.text = m_QuestionObject.OptionB;
		m_OptionC.text = m_QuestionObject.OptionC;
		m_OptionD.text = m_QuestionObject.OptionD;
		IsCorrect = false;
	}

	bool IsCorrect;
	public void SelectedOptionA()
	{
		IsCorrect =  m_QuestionObject.CheckAnswer ( 1 );

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
