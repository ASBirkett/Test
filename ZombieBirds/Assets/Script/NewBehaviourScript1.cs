using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {
	public Rigidbody otherBody;	

	// Use this for initialization
	//void Start () 
	//{

	//}
	
	// Update is called once per frame
	void Update () 
	{
		hingeJoint.connectedBody = null;
		hingeJoint.connectedBody = otherBody;
	}
}
