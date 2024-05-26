using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickingLight : MonoBehaviour
{
    public Light FlickerLight;
    public float minIntensity;
    public float maxIntensity;
    public float flickeringspeed;
    // Start is called before the first frame update
    void Start()
    {
        if(FlickerLight==null)
        {
            FlickerLight = GetComponent<Light>();

        }
    }

    // Update is called once per frame
    void Update()
    {
        float lightIntensity = Random.Range(minIntensity, maxIntensity);
        FlickerLight.intensity = Mathf.Lerp(FlickerLight.intensity, lightIntensity, flickeringspeed);
    }
}
