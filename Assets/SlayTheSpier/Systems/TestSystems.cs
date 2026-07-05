using UnityEngine;
using UnityEngine.InputSystem;

public class TestSystems : MonoBehaviour
{
    [SerializeField] private HandView handView;


    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            CardView cardView = CardViewCreator.Instance.CreateCardView(transform.position, Quaternion.identity);
            StartCoroutine(handView.AddCard(cardView));
            
        }
    }
}
