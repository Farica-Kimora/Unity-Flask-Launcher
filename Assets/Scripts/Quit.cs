using UnityEngine;

[DisallowMultipleComponent]
public class QuitScript : MonoBehaviour
{
    public void QuitApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}