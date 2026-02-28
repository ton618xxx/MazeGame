using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class KillZone : MonoBehaviour
{
    [SerializeField] private string _playerTag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _playerTag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
