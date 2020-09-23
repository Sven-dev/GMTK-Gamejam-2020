using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private int SceneIndex;
    [SerializeField] private Text ContinueText;


    private void Awake()
    {
        StartCoroutine(_Startup());
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(SceneIndex);
        }
    }

    private IEnumerator _Startup()
    {
        yield return new WaitForSeconds(3);
        enabled = true;
        StartCoroutine(_BlinkText());
    }

    private IEnumerator _BlinkText()
    {
        while(true)
        {
            ContinueText.enabled = !ContinueText.enabled;
            yield return new WaitForSeconds(0.75f);
        }
    }
}