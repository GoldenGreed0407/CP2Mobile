using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoadManager : MonoBehaviour
{
    [SerializeField] private float step;
    [SerializeField] private AudioSource cloverSound;
    [SerializeField] private AudioSource trashSound;
    [SerializeField] private CanvasMain canvasMain;
    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enter")
        {
            Vector3 p = other.transform.position;
            p.z += step;
            other.transform.position = p;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Clover"))
        {
            CanvasStats.collectable += 1;
            canvasMain.GetComponent<CanvasMain>().UpdateCounter();
            cloverSound.Play();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Trash"))
        {
            trashSound.Play();
            SceneManager.LoadScene("GameOverScene");
        }
    }

}
