using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor ( typeof ( QuizCollection ) )]
public class CI_QuizCollection : Editor
{
	public override void OnInspectorGUI ()
	{

		DrawDefaultInspector ( );
		QuizCollection myTarget = (QuizCollection)target;

		if ( GUILayout.Button ( "Add" ) )
		{
			myTarget.AddOption ( );
		}

	}
}

