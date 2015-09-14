using UnityEngine;
using System.Collections;

public class TransformAnimBehavior : MonoBehaviour
{
    public Vector3 LocalRotateEulerDelta = Vector3.zero;
    public bool ShouldRotateRelativeToGlobal = false;

    private void Update()
    {
        transform.Rotate(LocalRotateEulerDelta.x, LocalRotateEulerDelta.y, LocalRotateEulerDelta.z, ShouldRotateRelativeToGlobal ? Space.World : Space.Self);
    }
}
