using UnityEngine;
using UnityEngine.Events;


public class Activator : MonoBehaviour
{
	[TextArea (2,5)] public string  activationLine_RU;
	[TextArea (2,5)] public string  activationLine_ENG;
    public AudioSource AudioClip;

    public UnityEvent OnActivatedButtonDown;
    
    public void ActivateCursor()
	{
		if (Translator.LanguageId == 0)
		{
			UICursor.activeCursor.Activate(activationLine_RU);	
		}
		else if (Translator.LanguageId == 1)
		{
			UICursor.activeCursor.Activate(activationLine_ENG);	
		}
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