 using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICursor : MonoBehaviour
{
	private const float DISTANCE = 5;
	public static UICursor activeCursor { get; private set; }

	[SerializeField] TMP_Text text;
	[SerializeField] Image image;
	[SerializeField] LayerMask cursorLayer;

	public void Awake()
	{
		activeCursor = this;
	}

	public void Update()
	{
		
		var ray = new Ray(Camera.main.transform.position,
							Camera.main.transform.forward);
		if (Physics.Raycast(ray, out var info, DISTANCE, cursorLayer))
		{
			var activator_component = info.collider.GetComponent<Activator>();
			if (activator_component) activator_component.ActivateCursor();
			if (Input.GetKeyDown(KeyCode.E))
			{
				activator_component.Activate();

			}
		}
		else Deactivate();
	}

/*	public void OnDrawGizmos()
	{
		var ray = new Ray(Camera.main.transform.position,
							Camera.main.transform.forward);
		Gizmos.DrawRay(ray);
	}*/

	public void Activate(string actionText)
	{
		image.color = Color.red;
		text.gameObject.SetActive(true);
		text.text = actionText;
	}
	public void Deactivate() {
		image.color = Color.white;
		text.gameObject.SetActive(false);
	}
}
