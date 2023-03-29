using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{
    public int points = 0;
    public Button big1, big2, big3, big4, small1, small2, small3, small4, small5, small6, small7, small8;

    void Start()
    {
        big1.onClick.AddListener(delegate {TaskOnBigClick("big1");});
    }

    void TaskOnSmallClick()
    {
        Debug.Log("Small button has been pressed");
    }

    void TaskOnBigClick(string name)
    {
        if (name == "big1"){
            big1.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            big1.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
