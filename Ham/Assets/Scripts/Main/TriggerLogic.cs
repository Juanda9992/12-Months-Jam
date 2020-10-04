using UnityEngine;

public class TriggerLogic : MonoBehaviour
{

    #region PublicStuff
    public int cameraIndex;
    #endregion

    #region PrivateStuff
    private CameraController controller;
    #endregion

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            controller = GameObject.FindObjectOfType<CameraController>();
            controller.currentPos = cameraIndex;
        }    
    }

    #region Methods
    #endregion
}
