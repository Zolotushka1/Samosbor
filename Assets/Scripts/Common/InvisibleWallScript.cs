using UnityEngine;

public class InvisibleWallScript : MonoBehaviour
{
    [SerializeField] private GameObject switcher;
    void Update()
    {
        var script = switcher.GetComponent<Light_Switch>();
        if (script.isOn == true)
        {
            Destroy(this.gameObject);
        }
    }
}
