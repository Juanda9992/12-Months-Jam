using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    #region PublicStuff
    #endregion

    #region PrivateStuff
    #endregion

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }


    #region Methods
    #endregion
}
