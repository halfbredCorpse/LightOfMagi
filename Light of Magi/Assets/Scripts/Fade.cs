using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {

    private bool haltOut = false;

    private bool haltIn = false;



    public void FadeOut()
    {

        haltIn = true;

        haltOut = false;

        StartCoroutine(DoFadeOut());

    }



    IEnumerator DoFadeOut()
    {

        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();

        if (haltOut == true)
        {

            yield break;

        }

        while (canvasGroup.alpha > 0)
        {

            if (haltOut == true)
            {

                yield break;

            }

            canvasGroup.alpha -= Time.deltaTime / 2F;

            yield return null;

        }

        canvasGroup.interactable = false;

        yield return null;

    }



    public void FadeIn()
    {

        haltIn = false;

        haltOut = true;

        StartCoroutine(DoFadeIn());

    }



    IEnumerator DoFadeIn()
    {

        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();

        if (haltIn == true)
        {

            yield break;

        }

        while (canvasGroup.alpha < 0.999f)
        {

            if (haltIn == true)
            {

                yield break;

            }

            canvasGroup.alpha += Time.deltaTime / 2F;

            yield return null;

        }

        canvasGroup.interactable = false;

        yield return null;

    }

}
