using UnityEngine;
using System.Collections;
using Vuforia;

public class FaucetConfigureGUI : MonoBehaviour, ITrackableEventHandler 
{
	public static FaucetConfigureGUI Instance;

	[HideInInspector]
	public bool isGuiEnabled;
	public GameObject arMenu;

	TrackableBehaviour mTrackableBehaviour;

	// Use this for initialization
	void Start () 
	{
		Instance = this;

		isGuiEnabled = false;

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		
		if (mTrackableBehaviour) 
		{
			mTrackableBehaviour.RegisterTrackableEventHandler (this);
		}
	}
	
	public void OnTrackableStateChanged (TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			isGuiEnabled = true;	
		}
		else
		{
			isGuiEnabled = false;
		}
	}

	void Update ()
	{
		arMenu.SetActive (isGuiEnabled);

		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit ();
		}
	}
}
