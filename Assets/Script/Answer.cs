using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    [SerializeField] private Sprite answerPanel_Green;
    [SerializeField] private Sprite answerPanel_Red;
    [SerializeField] private Sprite answerPanel_Default;
    public bool isCorrect = false;
    public AnswerClick answerClick;
    public void AnswerBehavior(){
        if(isCorrect){
            answerClick.correctAnswer();
            Debug.Log("Correct");
            this.GetComponent<Image>().sprite = answerPanel_Green;
        }
        else if(!isCorrect){
            Debug.Log("Not Correct");
            this.GetComponent<Image>().sprite = answerPanel_Red;
        }
    }
}
