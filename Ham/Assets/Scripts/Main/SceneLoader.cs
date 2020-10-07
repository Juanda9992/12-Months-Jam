using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{

    #region PublicStuff
    public Animator transitionAnimator;
    public string levelToLoad;
    #endregion

    #region PrivateStuff
    #endregion

    public void LoadScene(string scene)
    {
        StartCoroutine(nextLevel(scene));
    }

    public IEnumerator nextLevel(string name)
    {
        transitionAnimator.SetTrigger("Active");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(name);
    }
    public void Restart()
    {
        StartCoroutine(ResetLevel());    
    }
    public IEnumerator ResetLevel()
    {
        CameraController camControll = Camera.main.GetComponent<CameraController>();
        transitionAnimator.SetTrigger("Active");
        yield return new WaitForSeconds(2);
        camControll.currentPos = 0;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Application.Quit();
    }

    #region Methods
    #endregion
}
