using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class SimplerestartOnCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}