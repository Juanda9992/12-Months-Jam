using UnityEngine;

public class CameraController : MonoBehaviour
{

    #region PublicStuff
    public float speed;
    public Vector3[] positions;

    #endregion

    #region PrivateStuff
    [HideInInspector] public int currentPos;
    #endregion
    void Update()
    {
        Vector3 currentPosition = positions[currentPos];
        transform.position = Vector3.Lerp(transform.position,currentPosition,2.0f * Time.deltaTime);
    }

    #region Methods
    #endregion
}
