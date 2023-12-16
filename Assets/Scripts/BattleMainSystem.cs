using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class BattleMainSystem : MonoBehaviour
{
    public Unit player;
    public Unit enemy;
    public Button button;
    public GameObject panel;
    public TextMeshProUGUI Text;
    public void Battle()
    {
        if(player.speed < enemy.speed)
        {
            enemy.Attack(player);
            enemy.hpSlider.value = enemy.hp;

            player.Attack(enemy);
            player.hpSlider.value = player.hp;
        }
        else
        {
            player.Attack(enemy);
            player.hpSlider.value = player.hp;

            enemy.Attack(player);
            enemy.hpSlider.value = enemy.hp;
        }
        if(player.hp <= 0)
        {
            panel.SetActive(true);
            Text.text = "YOU LOSE...";
        }
        else if (enemy.hp <= 0)
        {
            panel.SetActive(true);
            Text.text = "YOU WIN!";
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
