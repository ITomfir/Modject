using UnityEngine.UI;
using UnityEngine;

public class LoadProgressBar : MonoBehaviour
{
    [SerializeField] private FakeSceneLoader sceneLoader;
    [SerializeField] private Slider ProgressBar;

    private void Awake() {
        sceneLoader.OnUpdateProgressing += UpdateProgressing;
    }

    private void UpdateProgressing (float progress) {
        ProgressBar.value = progress;
    }
}
