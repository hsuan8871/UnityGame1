using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Player; // link GM with player
    [SerializeField] private TextMeshProUGUI HealthTxt;
    [SerializeField] private TextMeshProUGUI ScoreTxt;
    [SerializeField] private int InitScore;

    private int CurrentScroe;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 0;
        CurrentScroe = InitScore;
        UpdateUI();
        HealthTxt.text = Player.InitHealth.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            UpdateUI();
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
                Player.TakeDamage(1);
            }

        }
        startTime += Time.deltaTime;
        CurrentScroe = Mathf.RoundToInt(startTime);
    }

    public void UpdateUI() {
        HealthTxt.text = Player.CurrentHealth.ToString();
        ScoreTxt.text = CurrentScroe.ToString();
    }
}
