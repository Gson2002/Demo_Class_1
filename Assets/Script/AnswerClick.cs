using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerClick : MonoBehaviour
{
    [SerializeField] public List<QnA> qnA;
    [SerializeField] public GameObject[] options;
    [SerializeField] public int currentQuestion;
    [SerializeField] private TextMeshProUGUI questionTextField;

    private void Start()
    {
        questionGenarate();
    }
    public void correctAnswer(){
        questionGenarate();
        qnA.RemoveAt(currentQuestion);
    }
    public void setAnswer(){
        for(int i = 0; i < options.Length; i++){
            options[i].GetComponent<Answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = qnA[currentQuestion].Answer[i]; 
            if(qnA[currentQuestion].correctAnswer == i+1){
                options[i].GetComponent<Answer>().isCorrect = true;
            }
        }
    }
    public void questionGenarate(){
        currentQuestion = Random.Range(0, qnA.Count);
        questionTextField.text = qnA[currentQuestion].Question;
        setAnswer();
        qnA.RemoveAt(currentQuestion);
    }
}

