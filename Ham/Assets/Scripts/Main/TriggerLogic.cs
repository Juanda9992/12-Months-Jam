using UnityEngine;

public class TriggerLogic : MonoBehaviour
{

    #region PublicStuff
    public int cameraIndex;
    public string soundToPlay;
    #endregion

    #region PrivateStuff
    private CameraController controller;
    bool hasPlayed = false;
    #endregion

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            controller = GameObject.FindObjectOfType<CameraController>();
            controller.currentPos = cameraIndex;
            if(soundToPlay != null && hasPlayed == false)
            {
                hasPlayed = true;
                SoundManager.PlaySound(soundToPlay);
            }
        }
    }

    #region Methods
    #endregion
}
