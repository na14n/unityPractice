using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneTwoGameHandler : MonoBehaviour
{
    public GameObject player2HPUI;
    public GameObject player1HPUI;

    public int player1HP = 100;
    public int player2HP = 100;

    IEnumerator delayPress(){
        yield return new WaitForSeconds(3f);
        Debug.Log("Start");
    }

    void dealDamage(int damageAmount, float accuracy, int playerHP, int playerN){

        int x = Random.Range(1,101);
        if (playerN == 2){
            if (x <= accuracy){
            playerHP -= damageAmount;
            player2HP = playerHP;
        }
        }
        if (playerN == 1){
            if (x <= accuracy){
            playerHP -= damageAmount;
            player1HP = playerHP;
        }
        }
        
        
    }

    public void p1LowPunch(){
        dealDamage(5, 60, player2HP,2);
    }

    public void p1HighPunch(){
        dealDamage(10, 30, player2HP,2);
    }

    public void p2LowPunch(){
        dealDamage(5, 60, player1HP,1);
    }

    public void p2HighPunch(){
        dealDamage(10, 30, player1HP,1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player1HP + "";
        player2HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player2HP + "";
    }
}
