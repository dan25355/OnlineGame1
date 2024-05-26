using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLight1 : MonoBehaviour
{
    public Light MyLight;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Blink());
    }

    // Update is called once per frame
   
    
    
    IEnumerator Blink()    
    {   while (true) 
        {
            MyLight.enabled = false;
            yield return new WaitForSeconds(3);
            MyLight.enabled = true;
            yield return new WaitForSeconds(0.5f);
        }

    }






}
