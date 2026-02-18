using UnityEngine;

public class OriginalToTarget : MonoBehaviour
{
    [SerializeField] private Transform _original;
    [SerializeField] private Transform _target;

    private void Start ()
    {
         Vector3 displacementToTarget = _original.position - _target.position;
        Debug.Log(displacementToTarget);
        _original.position += displacementToTarget;

        
    }
}