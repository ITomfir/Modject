using System.Collections;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeSceneLoader : MonoBehaviour
{
    public event Action<float> OnUpdateProgressing; 

    public float progress { get; private set; }

    [SerializeField] private int _indexScene;
    [SerializeField] private float _bootDelay;

    public void Awake () {
        StartCoroutine(FakeLoad(_indexScene));
    }

    public IEnumerator FakeLoad (int indexScene) {
        var delay = _bootDelay;

        while (delay > 0) {
            delay -= Time.deltaTime;

            progress = 1f - (delay / _bootDelay);
            OnUpdateProgressing?.Invoke(progress);

            if (delay <= 0) SceneManager.LoadScene(indexScene);

            yield return null;
        }
    }   
}