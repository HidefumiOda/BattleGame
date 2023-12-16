using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class BeforeBattleMainSystem : MonoBehaviour
{
    public Button button;
    void MoveBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(MoveBattleScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
