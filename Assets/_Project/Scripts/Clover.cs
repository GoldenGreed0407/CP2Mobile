using UnityEngine;

public class Clover : MonoBehaviour
{
    private AudioSource som;
    GameObject canvasMain;
    void Start()
    {
        canvasMain = GameObject.Find("CanvasMain");
        som = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CanvasStats.collectable += 1;
            canvasMain.GetComponent<CanvasMain>().UpdateCounter();
            Destroy(gameObject);
            som.Play();
        }
    }
}
