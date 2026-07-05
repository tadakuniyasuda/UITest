using UnityEngine;

public class Billbaord : MonoBehaviour
{
    private Transform mainCameraTransform;
    [SerializeField] private Transform TargetObjectTransform;
    [SerializeField] private bool TrackObject = true;
    void Start()
    {
        mainCameraTransform = Camera.main.transform;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (TrackObject)
        {
            Quaternion rotation = mainCameraTransform.rotation;
            transform.LookAt(transform.position + rotation * Vector3.forward, rotation * Vector3.up);
        }
        else
        {
            Vector3 RelativedPos= TargetObjectTransform.position - transform.position;
            Quaternion.LookRotation(RelativedPos);
        }
            
        
        

    }
}
