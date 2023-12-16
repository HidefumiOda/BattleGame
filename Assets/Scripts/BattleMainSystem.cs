using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class BattleMainSystem : MonoBehaviour
{
    int BeforePlayerHp;
    int BeforeEnemyHp;
    public Unit player;
    public Unit enemy;
    public Button button;
    public GameObject AfterBattlePanel;
    public GameObject BattlePanel;
    public TextMeshProUGUI AfterBattleText;
    public TextMeshProUGUI Text;
    public void Battle()
    {
        if(player.speed < enemy.speed)
        {
            Text.text = "敵の攻撃！\n";
            BeforePlayerHp = player.hp;
            enemy.Attack(player);
            enemy.hpSlider.value = enemy.hp;
            Text.text = BeforePlayerHp - player.hp + "ダメージを受けた...\n";

            Text.text = "攻撃をした！\n";
            BeforeEnemyHp = enemy.hp;
            player.Attack(enemy);
            player.hpSlider.value = player.hp;
            Text.text = BeforeEnemyHp - enemy.hp + "ダメージを与えた！\n";
        }
        else
        {
            Text.text = "攻撃をした！\n";
            BeforeEnemyHp = enemy.hp;
            player.Attack(enemy);
            player.hpSlider.value = player.hp;
            Text.text = BeforeEnemyHp - enemy.hp + "ダメージを与えた！\n";

            Text.text = "敵の攻撃！\n";
            BeforePlayerHp = player.hp;
            enemy.Attack(player);
            enemy.hpSlider.value = enemy.hp;
            Text.text = BeforePlayerHp - player.hp + "ダメージを受けた...\n";
        }
        if(player.hp <= 0)
        {
            AfterBattlePanel.SetActive(true);
            BattlePanel.SetActive(false);
            AfterBattleText.text = "あなたの負け...";
            player.hpSlider.value = 0;
        }
        else if (enemy.hp <= 0)
        {
            AfterBattlePanel.SetActive(true);
            BattlePanel.SetActive(false);
            AfterBattleText.text = "あなたの勝ち！";
            enemy.hpSlider.value = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Battle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
