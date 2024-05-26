using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class falding : MonoBehaviour
{
    public TextMeshProUGUI gameName;
    public float fadeSpeed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FaldingText());
    }

    // Update is called once per frame
    IEnumerator FaldingText()
    {
        yield return new WaitForSeconds(2);
        Color originalcolor = gameName.color;
        float currentTime = 0;

        while (currentTime < fadeSpeed)
        {
            currentTime += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, currentTime / fadeSpeed);
            gameName.color = new Color(originalcolor.r, originalcolor.g, originalcolor.b, alpha);
            yield return null;


        }




    }



}