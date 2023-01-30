using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Buttons : MonoSingleton<Buttons>
{
    //managerde bulunacak

    [SerializeField] private GameObject _globalPanel;

    public GameObject _startPanel;
    [SerializeField] Button _startButton;

    [SerializeField] private Button _settingButton;
    [SerializeField] private GameObject _settingGame;

    [SerializeField] private Sprite _red, _green;
    [SerializeField] private Button _settingBackButton;
    [SerializeField] private Button _soundButton, _vibrationButton;

    public GameObject winPanel, failPanel;
    [SerializeField] private Button _winPrizeButton, _winEmptyButton, _failButton;

    public TMP_Text finishGameMoneyText;

    public TMP_Text moneyText, levelText;

    private void Start()
    {
        ButtonPlacement();
        SettingPlacement();
        levelText.text = GameManager.Instance.level.ToString();
    }
    public IEnumerator NoThanxOnActive()
    {
        _winEmptyButton.gameObject.SetActive(false);
        yield return new WaitForSeconds(3);
        _winEmptyButton.gameObject.SetActive(true);
    }

    private void SettingPlacement()
    {
        SoundSystem soundSystem = SoundSystem.Instance;
        GameManager gameManager = GameManager.Instance;
        Image soundImage = _soundButton.gameObject.GetComponent<Image>();
        Image vibrationImage = _vibrationButton.gameObject.GetComponent<Image>();

        if (gameManager.sound == 1)
        {
            soundImage.sprite = _green;
            soundSystem.MainMusicPlay();
        }
        else
        {
            soundImage.sprite = _red;
            soundSystem.MainMusicStop();
        }

        if (gameManager.vibration == 1)
        {
            vibrationImage.sprite = _green;
        }
        else
        {
            vibrationImage.sprite = _red;
        }
    }
    private void ButtonPlacement()
    {
        _settingButton.onClick.AddListener(SettingButton);
        _settingBackButton.onClick.AddListener(SettingBackButton);
        _soundButton.onClick.AddListener(SoundButton);
        _vibrationButton.onClick.AddListener(VibrationButton);
        _winPrizeButton.onClick.AddListener(() => StartCoroutine(WinPrizeButton()));
        _winEmptyButton.onClick.AddListener(() => StartCoroutine(WinButton()));
        _failButton.onClick.AddListener(() => StartCoroutine(FailButton()));
        _startButton.onClick.AddListener(StartButton);
    }

    private void StartButton()
    {
        _startPanel.SetActive(false);
        TimerSystem.Instance.TimerPanel.SetActive(true);
        ContractUISystem.Instance.TaskPanel.SetActive(true);
        WrongSystem.Instance.FailPanel.SetActive(true);
        GameManager.Instance.isStart = true;

        StartCoroutine(SpawnSystem.Instance.SpawnStart());
        TimerSystem.Instance.StartTimer();
        ContractUISystem.Instance.UIPlacement();
        //StartCoroutine(TimerSystem.Instance.TimerStart());
    }
    private IEnumerator WinButton()
    {
        _winPrizeButton.enabled = false;
        BarSystem.Instance.BarStopButton(0);
        GameManager.Instance.SetLevel();
        MoneySystem.Instance.MoneyTextRevork(GameManager.Instance.addedMoney);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
    private IEnumerator WinPrizeButton()
    {
        _winPrizeButton.enabled = false;
        BarSystem.Instance.BarStopButton(GameManager.Instance.addedMoney);
        GameManager.Instance.SetLevel();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
    private IEnumerator FailButton()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
    private void SettingButton()
    {
        _startPanel.SetActive(false);
        _settingGame.SetActive(true);
        _settingButton.gameObject.SetActive(false);
        _globalPanel.SetActive(false);
    }
    private void SettingBackButton()
    {
        if (!GameManager.Instance.isStart)
            _startPanel.SetActive(true);
        _settingGame.SetActive(false);
        _settingButton.gameObject.SetActive(true);
        _globalPanel.SetActive(true);
    }
    private void SoundButton()
    {
        GameManager gameManager = GameManager.Instance;

        if (gameManager.sound == 1)
        {
            _soundButton.gameObject.GetComponent<Image>().sprite = _red;
            SoundSystem.Instance.MainMusicStop();
            gameManager.sound = 0;
        }
        else
        {
            _soundButton.gameObject.GetComponent<Image>().sprite = _green;
            SoundSystem.Instance.MainMusicPlay();
            gameManager.sound = 1;
        }

        gameManager.SetSound();
    }
    private void VibrationButton()
    {
        GameManager gameManager = GameManager.Instance;

        if (gameManager.vibration == 1)
        {
            _vibrationButton.gameObject.GetComponent<Image>().sprite = _red;
            gameManager.vibration = 0;
        }
        else
        {
            _vibrationButton.gameObject.GetComponent<Image>().sprite = _green;
            gameManager.vibration = 1;
        }

        gameManager.SetVibration();
    }

}
