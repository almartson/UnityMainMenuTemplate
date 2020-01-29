using UnityEngine;

/// <summary>
/// This class allows us to load a scene when clicked.
/// </summary>
public class LoadOnClick : MonoBehaviour
{

    /// <summary>
    /// My loading image.
    /// </summary>
    [Tooltip("Image with Slider and al UI stuff that will appear: while Loading.")]
    public GameObject _myLoadingImage;


    public void LoadScene(int level)
    {
        // Set the image as: Active.
        //
        if ( this._myLoadingImage != null )
        {
            this._myLoadingImage.SetActive(true);

        }//End if
        //
        Application.LoadLevel(level);
    }
}
