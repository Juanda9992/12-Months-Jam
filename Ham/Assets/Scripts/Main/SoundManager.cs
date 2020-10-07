using UnityEngine;

public class SoundManager : MonoBehaviour
{

    #region PublicStuff
    public static AudioClip cheer, womenLaught, suspense,fallSound,rain,boom,cry,wind;
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
        rain = Resources.Load<AudioClip>("Rain");
        boom = Resources.Load<AudioClip>("Boom");
        cry = Resources.Load<AudioClip>("Cry");
        wind = Resources.Load<AudioClip>("Wind");
    }

    public static void PlaySound(string sound)
    {
        switch (sound)
        {
            case "Wind":
            audioSource.PlayOneShot(wind);
            break;
            case "Cry":
            audioSource.PlayOneShot(cry);
            break;
            case "Boom":
            audioSource.PlayOneShot(boom);
            break;
            case "Rain":
            audioSource.PlayOneShot(rain);
            break;
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
