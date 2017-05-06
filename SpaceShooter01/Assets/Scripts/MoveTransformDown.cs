using System.Collections;
using UnityEngine;

public class MoveTransformDown : MonoBehaviour
{
	public float transformSpeed = 0.01f;

	void Start ()
	{

	}

	void Update ()
	{
		moveToBottom ();
	}

	void moveToBottom ()
	{
		transform.Translate (0, -transformSpeed, 0);
	}
}
