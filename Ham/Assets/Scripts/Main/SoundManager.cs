using UnityEngine;

public class SoundManager : MonoBehaviour
{

    #region PublicStuff
    public static AudioClip cheer, womenLaught, suspense,fallSound;
    #endregion

    #region PrivateStuff
    private static AudioSource audioSource;
    #endregion

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        cheer = Resources.Load<AudioClip>("Cheer");
        womenLaught = Resources.Load<AudioClip>("Woman");
        suspense = Resources.Load<AudioClip>("Suspense");
        fallSound = Resources.Load<AudioClip>("Fall");
    }

    public static void PlaySound(string sound)
    {
        switch (sound)
        {
            case "Cheer":
            audioSource.PlayOneShot(cheer);
            break;
            case "Laught":
            audioSource.PlayOneShot(womenLaught);
            break;
            case "Suspense":
            audioSource.PlayOneShot(suspense);
            break;
            case "Fall":
            audioSource.PlayOneShot(fallSound);
            break;
        }
    }

    #region Methods
    #endregion
}
