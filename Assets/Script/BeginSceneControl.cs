using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BeginSceneControl : MonoBehaviour
{
    public GameObject beginScene;
    public GameObject loadScene;
    public GameObject gameScene;

    public Text text;
    bool loadSceneActive;

    float time=61;
    int second = 0;
    int infoNum=0;
    string[] info =
    {
        "市长正在赶来。。",
        "市长正在赶来。。。",
        "市长正在赶来。。。。",
        "市长正在赶来。。。。。"
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextChange();
        LoadFinish();
    }
    void TextChange()
    {
        if (loadSceneActive && time > 30)
        {
            text.text = info[infoNum];
            infoNum++;
            if (infoNum > 3)
            {
                infoNum = 0;
            }
            time = 0;
            second++;
        }
        time++;
    }
    void LoadFinish()
    {
        if (second > 6)
        {
            loadScene.SetActive(false);
            gameScene.SetActive(true);
            beginScene.SetActive(false);
        }

    }
    public void OnBeginButtonClick()
    {
       
        loadScene.SetActive(true);
        loadSceneActive = true;
    }

    IEnumerator TextChangeFun()
    {

        yield return new WaitForSeconds(1);
    }
}
