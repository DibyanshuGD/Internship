using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Text[] buttons;
    public Text resultText;

    private string currentPlayer = "X";
    private bool gameOver = false;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void OnEnable()
    {
        InputManager.Instance.OnCellClicked += HandleCellClick;
        InputManager.Instance.OnRestartKeyPressed += RestartGame;
    }

    void OnDisable()
    {
        InputManager.Instance.OnCellClicked -= HandleCellClick;
        InputManager.Instance.OnRestartKeyPressed -= RestartGame;
    }

    void HandleCellClick(int index)
    {
        if (buttons[index].text == "" && !gameOver)
        {
            buttons[index].text = currentPlayer;

            SoundManager.Instance.PlayClick();

            CheckResult();

            if (!gameOver)
                SwitchPlayer();
        }
    }

    void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == "X") ? "O" : "X";
    }

    void CheckResult()
    {
        int[,] winConditions = new int[,]
        {
            {0,1,2}, {3,4,5}, {6,7,8},
            {0,3,6}, {1,4,7}, {2,5,8},
            {0,4,8}, {2,4,6}
        };

        for (int i = 0; i < 8; i++)
        {
            int a = winConditions[i, 0];
            int b = winConditions[i, 1];
            int c = winConditions[i, 2];

            if (buttons[a].text == currentPlayer &&
                buttons[b].text == currentPlayer &&
                buttons[c].text == currentPlayer)
            {
                resultText.text = currentPlayer + " Wins!";
                gameOver = true;

                SoundManager.Instance.PlayWin();
                return;
            }
        }

        bool draw = true;
        foreach (Text t in buttons)
        {
            if (t.text == "")
            {
                draw = false;
                break;
            }
        }

        if (draw)
        {
            resultText.text = "Draw!";
            gameOver = true;
        }
    }

    public void RestartGame()
    {
        foreach (Text t in buttons)
        {
            t.text = "";
        }

        resultText.text = "";
        currentPlayer = "X";
        gameOver = false;
    }
}


