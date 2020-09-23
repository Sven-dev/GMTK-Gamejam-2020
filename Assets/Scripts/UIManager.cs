using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text YellowText;
    [SerializeField] private Text PurpleText;
    [SerializeField] private Text RedText;
    [Space]
    [SerializeField] private int YellowAmount; 
    [SerializeField] private int PurpleAmount; 
    [SerializeField] private int RedAmount;
    [Space]
    [SerializeField] private GameObject VictoryLabel;
    [Space]
    [Header("Audio")]
    [SerializeField] private AudioSource Audio;
    [SerializeField] private AudioClip Watered;
    [SerializeField] private AudioClip ItemComplete;

    private int YellowCurrent = 0; 
    private int PurpleCurrent = 0; 
    private int RedCurrent = 0; 

    // Start is called before the first frame update
    private void Start()
    {
        Flower.OnWatered += UpdateChecklist;
    }

    private void UpdateChecklist(FlowerColor color)
    {
        switch(color)
        {
            case FlowerColor.Yellow:
                YellowCurrent++;
                YellowText.text = YellowCurrent + "/" + YellowAmount;

                if (YellowCurrent == YellowAmount)
                {
                    ItemCompleteSFX();
                }
                else
                {
                    WateredSFX();
                }
                break;

            case FlowerColor.Purple:
                PurpleCurrent++;
                PurpleText.text = PurpleCurrent + "/" + PurpleAmount;
                if (PurpleCurrent == PurpleAmount)
                {
                    ItemCompleteSFX();
                }
                else
                {
                    WateredSFX();
                }
                break;

            case FlowerColor.Red:
                RedCurrent++;
                RedText.text = RedCurrent + "/" + RedAmount;
                if (RedCurrent == RedAmount)
                {
                    ItemCompleteSFX();
                }
                else
                {
                    WateredSFX();
                }

                break;
        }

        if (YellowAmount == YellowCurrent && PurpleAmount == PurpleCurrent && RedAmount == RedCurrent)
        {
            StartCoroutine(DisplayVictoryScreen());
        }
    }

    private IEnumerator DisplayVictoryScreen()
    {
        yield return new WaitForSeconds(1f);
        VictoryLabel.SetActive(true);
    }

    private void OnDestroy()
    {
        Flower.OnWatered -= UpdateChecklist;
    }

    private void WateredSFX()
    {
        Audio.PlayOneShot(Watered);
    }

    private void ItemCompleteSFX()
    {
        Audio.PlayOneShot(ItemComplete);
    }
}