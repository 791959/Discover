using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject image;
    public Transform[] buttonLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLeftButtonClick()
    {
       StartCoroutine(Fun(0));
    }
    public void OnRightButtonClick()
    {
        StartCoroutine(Fun(1));
    }

    IEnumerator Fun(int i)
    {
        image.transform.position = buttonLocation[i].position;
        image.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        image.SetActive(false);
    }
}
