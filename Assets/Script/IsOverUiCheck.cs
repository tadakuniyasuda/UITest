using UnityEngine;
using UnityEngine.EventSystems;

public class IsOverUiCheck : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
            if(EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("Pointer is over UI");
            }
    }
}
