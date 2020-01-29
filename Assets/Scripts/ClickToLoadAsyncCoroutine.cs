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
    /// My loading image.
    /// </summary>
    [Tooltip("Image with Slider and al UI stuff that will appear: while Loading.")]
    public GameObject _myLoadingImage;

    /// <summary>
    /// Async operation object, which will allow for 'asking questions', such as: 'Are you done?'.
    /// </summary>
    private AsyncOperation _myAsyncOperation;


    #region Custom Methods

    public void ClickAsync(int level)
    {
        _myLoadingImage.SetActive(true);
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
