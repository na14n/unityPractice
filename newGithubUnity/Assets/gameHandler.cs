using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore = 0;
    public float gameDuration = 0f;
    public GameObject timerTextGO;
    

    public void setGameDuration(float amount, bool additive){
        if(additive == true){
            gameDuration += amount;
        }
        else
        {
            gameDuration = amount;
        }
    }

    public void resetTimer(){
        StartCoroutine(delayPress());
        setGameDuration(300, false);
        Debug.Log("Start");
    }

    //Always use 'f' after number to indicate float regardless if float type is indicated
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //use script to put text on the TextMeshPro
        timerTextGO.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = gameDuration + "";
    }

    void FixedUpdate()
    {
        //Physics and Time
        gameDuration -= Time.deltaTime;
    }

    IEnumerator delayPress(){
        yield return new WaitForSeconds(3f);
        Debug.Log("Start");
        //SceneManager.LoadScene(1);
    }
}
