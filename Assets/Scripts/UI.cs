//http://answers.unity3d.com/questions/971009/make-ui-elements-invisible.html

using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
    public CanvasGroup canvasGroup;
    public bool visible = false;


    public void Hide()
    {
        canvasGroup.alpha = 0f; //this makes everything transparent
        canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
        visible = false;
    }

    public void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        visible = true;
    }


}
