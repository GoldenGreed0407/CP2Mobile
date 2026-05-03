using UnityEngine;
using UnityEngine.UI;

public class CanvasMain : MonoBehaviour
{
    [SerializeField] public Text textCollectableCount;
    [SerializeField] public Text textTime;

    private void Start()
    {
        CanvasStats.collectable = 0;
        CanvasStats.time = -3;
    }
    public void UpdateCounter()
    {
        textCollectableCount.text = CanvasStats.collectable.ToString();
    }
    public void UpdateTime()
    {
        textTime.text = CanvasStats.time.ToString();
    }
}
