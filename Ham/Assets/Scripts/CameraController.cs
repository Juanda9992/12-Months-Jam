using UnityEngine;

public class CameraController : MonoBehaviour
{

    #region PublicStuff
    public float speed;
    public Vector3[] positions;

    #endregion

    #region PrivateStuff
    private int currentPos;
    #endregion
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            currentPos --;
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(currentPos < positions.Length - 1)
            currentPos++;
        }
        Vector3 currentPosition = positions[currentPos];
        transform.position = Vector3.Lerp(transform.position,currentPosition,2.0f * Time.deltaTime);
    }

    #region Methods
    #endregion
}
