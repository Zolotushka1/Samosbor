using UnityEngine;
using UnityEngine.Events;


public class Activator : MonoBehaviour
{
	public string activationLine;
    

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
		OnActivatedButtonDown.Invoke();

	}

}