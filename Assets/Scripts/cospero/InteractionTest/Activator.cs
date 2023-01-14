using UnityEngine;
using UnityEngine.Events;


public class Activator : MonoBehaviour
{
	public string activationLine;
    public AudioSource AudioClip;

    public UnityEvent OnActivatedButtonDown;
    
    public void ActivateCursor()
	{
		UICursor.activeCursor.Activate(activationLine);
	}
	public void DeactivateCursor()
	{
		UICursor.activeCursor.Deactivate();
	}
	public void Activate()
	{
		if (AudioClip != null)
		{
            AudioClip.Play();
        }
			
        OnActivatedButtonDown.Invoke();

	}

}