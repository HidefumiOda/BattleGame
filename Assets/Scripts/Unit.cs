using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int hp;
    public int power;
    public int speed;
    public Slider hpSlider;
    public void Attack(Unit target)
    {
        if(hp > 0)
        {
            int random = Random.Range(0, 2);
            if(random == 0)
            {
                target.hp = target.hp - (power * 2);
            }
            else
            {
                target.hp = target.hp - power;
            }
        }
        else
        {
            hp = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
