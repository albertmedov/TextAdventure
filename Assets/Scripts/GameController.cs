using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI storyText; 
    public TextMeshProUGUI firstOptionButton; 
    public TextMeshProUGUI secondOptionButton; 

    private int currentStep = 0; 

    void Start()
    {
        ShowStep(0); 
    }

    public void OnButton1Click()
    {
        ShowStep(1); 
    }

    public void OnButton2Click()
    {
        ShowStep(2); 
    }

    void ShowStep(int step)
    {
        currentStep = step;

        switch (step)
        {
            case 0:
                storyText.text = "Вы стоите на распутье. Что вы сделаете?";
                firstOptionButton.text = "Идти налево";
                secondOptionButton.text = "Идти направо";
                break;

            case 1:
                storyText.text = "Вы пошли налево и встретили волка.";
                firstOptionButton.text = "Сражаться";
                secondOptionButton.text = "Убежать";
                break;

            case 2:
                storyText.text = "Вы пошли направо и нашли сундук с сокровищами!";
                firstOptionButton.text = "Открыть сундук";
                secondOptionButton.text = "Идти дальше";
                break;

            default:
                storyText.text = "Конец истории.";
                firstOptionButton.text = "Начать заново";
                secondOptionButton.text = "Выйти";
                break;
        }
    }
}