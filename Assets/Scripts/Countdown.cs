using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] private Text CountdownField;
    [SerializeField] private Pusher Pusher;
    [SerializeField] private GameMusic Music;

    private void Start()
    {
        StartCoroutine(_Countdown());
    }

    private IEnumerator _Countdown()
    {
        yield return new WaitForSeconds(1);
        CountdownField.text = "3";
        yield return new WaitForSeconds(1);
        CountdownField.text = "2";
        yield return new WaitForSeconds(1);
        CountdownField.text = "1";
        Music.StartMusic();
        yield return new WaitForSeconds(1);
        CountdownField.text = "GO!";
        Pusher.Activate();
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }
}
