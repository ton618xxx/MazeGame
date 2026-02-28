using UnityEngine;

public class MusicRepeater : MonoBehaviour
{
    private static MusicRepeater _musicRepeater;

    private void Awake()
    {
        if (_musicRepeater != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            _musicRepeater = this;
        }
    }
}
