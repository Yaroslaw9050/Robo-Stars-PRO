using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GamePlayerStatisticComponent : PlayerStatisticComponent
{
    [SerializeField] TMP_Text titleText;
    [SerializeField] TMP_Text levelText;
    [SerializeField] TMP_Text currentEXP_Text;
    [SerializeField] Image fillEXP_Area;
    private PlayerSetting playerSetting;
    private const int LOOSE_COEFFICIENT = 1;
    private const int WIN_COEFFICIENT = 3;
    private const int STANDAR_EXP_VALUE = 50;
    public override void Awake()
    {
        base.Awake();
        playerSetting = gameObject.GetComponentInChildren<PlayerSetting>();
    }
    public void ShowWinInfo()
    {
        int value = (playerLevel * STANDAR_EXP_VALUE) * WIN_COEFFICIENT;
        if(currentEXP + value > EXPtoNextLevel)
        {
            int bufferValue = (currentEXP + value) - EXPtoNextLevel;
            playerLevel++;
            currentEXP = bufferValue;
            UpdateEXPToNextLevel();
        }
        else
        {
            currentEXP += value;
        }
        titleText.text = "YOU WIN!";
        UpdateText();
        SaveData();
    }
    public void ShowLooseInfo()
    {
        int value = (playerLevel * STANDAR_EXP_VALUE) * LOOSE_COEFFICIENT;
        if(currentEXP + value > EXPtoNextLevel)
        {
            int bufferValue = (currentEXP + value) - EXPtoNextLevel;
            playerLevel++;
            currentEXP = bufferValue;
            UpdateEXPToNextLevel();
        }
        else
        {
            currentEXP += value;
        }
        titleText.text = "YOU LOOSE!";
        UpdateText();
        SaveData();
    }
    private void UpdateText()
    {
        levelText.text = $"Level: {playerLevel}";
        currentEXP_Text.text = $"{currentEXP} / {EXPtoNextLevel}";
        fillEXP_Area.fillAmount = (float)currentEXP / (float)EXPtoNextLevel;
    }
    private void SaveData()
    {
        PlayerPrefs.SetInt("PlayerLevel", playerLevel);
        PlayerPrefs.SetInt("CurrentEXP", currentEXP);
    }
}
