using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PillandPortal : MonoBehaviour
{

    #region PublicStuff
    public Light2D portalLight;
    public GameObject pillObject;
    public ParticleSystem particle;
    public float maxLight;
    #endregion

    #region PrivateStuff
    float lightIntensity = 0;
    bool actived = false;
    #endregion

    private void Update() 
    {
        if(actived && lightIntensity < maxLight)
        {
            lightIntensity += 1 * Time.deltaTime;
        }
        portalLight.intensity = lightIntensity;    	
        Debug.Log("Light =" + lightIntensity);
    }

    public void togglePortal()
    {
        pillObject.SetActive(false);
        actived = true;

    } 
    private void OnTriggerEnter2D(Collider2D other) 
    {
        pillObject.SetActive(false);    
        particle.Stop();
        togglePortal();
        Destroy(this.gameObject,1);
    }
    #region Methods
    #endregion
}
