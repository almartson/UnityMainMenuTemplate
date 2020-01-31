using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickToLoadAsyncCoroutine : MonoBehaviour
{

    /// <summary>
    /// My loading (Slider - Progress) Bar.
    /// </summary>
    [Tooltip("Loading (Slider - Progress) Bar")]
    public Slider _myLoadingBar;

    /// <summary>
    /// (Canvas of) Image with Slider and al UI stuff that will appear: while Loading.
    /// </summary>
    [Tooltip("(Canvas of) Image with Slider and al UI stuff that will appear: while Loading.")]
    public Canvas _myCanvasComponentOfLoadingImage;

    /// <summary>
    /// Async operation object, which will allow for 'asking questions', such as: 'Are you done?'.
    /// </summary>
    private AsyncOperation _myAsyncOperation;


    #region Custom Methods

    public void ClickAsync(int level)
    {
        ///_myLoadingImage.SetActive(true); // This is SubOptimal.
        // Set the image as: Active.
        //
        if (this._myCanvasComponentOfLoadingImage != null)
        {
            this._myCanvasComponentOfLoadingImage.enabled = true;

        }//End if
        //
        StartCoroutine(LoadLevelWithBar(level));

    }//End Method


    IEnumerator LoadLevelWithBar (int level)
    {
        _myAsyncOperation = Application.LoadLevelAsync(level);
        while (!_myAsyncOperation.isDone)
        {
            _myLoadingBar.value = _myAsyncOperation.progress;
            yield return null;
        }
    }//End Method

    #endregion Custom Methods

}
