using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    [SerializeField] private CanvasMain canvasMain;
    void Start()
    {
        StartCoroutine(Time());
    }

    private void Update()
    {
        if(CanvasStats.collectable >= 30)
        {
            SceneManager.LoadScene("VictoryScene");
        }
    }

    IEnumerator Time()
    {
        yield return new WaitForSeconds(1);
        CanvasStats.time += 1;
        canvasMain.GetComponent<CanvasMain>().UpdateTime();
        StartCoroutine(Time());
    }
}
