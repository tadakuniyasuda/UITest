using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shape : MonoBehaviour
{
   [SerializeField] private Transform Cylinder, Sphere;
   [SerializeField] private float _circleLength = 2;

   void Update()
   {

      if (Keyboard.current.spaceKey.wasPressedThisFrame)
      {
         Sphere.transform.DOMove(new Vector3(10f, 0, 0), _circleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
      }
   
   }
}
