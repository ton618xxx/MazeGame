using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class FinishLevel : MonoBehaviour
{
    [SerializeField] private string _playerTag;
    [SerializeField] private string _nextSceneName;

    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _playerTag)
        {
            SceneManager.LoadScene(_nextSceneName);
        }
    }
}
