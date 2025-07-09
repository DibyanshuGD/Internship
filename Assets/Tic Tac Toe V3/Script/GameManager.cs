using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    public TMP_Text Text1, Text2, Text3, Text4, Text5, Text6, Text7, Text8, Text9;
    public TMP_Text PlayerX, PlayerO, msg;

    private bool isXTurn = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                string name = hit.collider.name;

                if (name == "Text1") 
                    Button(0);
                else if (name == "Text2") 
                    Button(1);
                else if (name == "Text3")
                    Button(2);
                else if (name == "Text4") 
                    Button(3);
                else if (name == "Text5") 
                    Button(4);
                else if (name == "Text6") 
                    Button(5);
                else if (name == "Text7") 
                    Button(6);
                else if (name == "Text8") 
                    Button(7);
                else if (name == "Text9") 
                    Button(8);
            }
        }
    }

    public void Button(int index)
    {
        TMP_Text box = GetTextByIndex(index);
        if (box.text != "") return;
        box.text = isXTurn ? "X" : "O";
        isXTurn = !isXTurn;
        CheckWinner();
    }

    TMP_Text GetTextByIndex(int i)
    {
        switch (i)
        {
            case 0: return Text1;
            case 1: return Text2;
            case 2: return Text3;
            case 3: return Text4;
            case 4: return Text5;
            case 5: return Text6;
            case 6: return Text7;
            case 7: return Text8;
            default: return Text9;
        }
    }

    void CheckWinner()
    {
        string t1 = Text1.text, t2 = Text2.text, t3 = Text3.text;
        string t4 = Text4.text, t5 = Text5.text, t6 = Text6.text;
        string t7 = Text7.text, t8 = Text8.text, t9 = Text9.text;

        CheckLine("X", t1, t2, t3);
        CheckLine("X", t4, t5, t6);
        CheckLine("X", t7, t8, t9);
        CheckLine("X", t1, t4, t7);
        CheckLine("X", t2, t5, t8);
        CheckLine("X", t3, t6, t9);
        CheckLine("X", t1, t5, t9);
        CheckLine("X", t3, t5, t7);

        CheckLine("O", t1, t2, t3);
        CheckLine("O", t4, t5, t6);
        CheckLine("O", t7, t8, t9);
        CheckLine("O", t1, t4, t7);
        CheckLine("O", t2, t5, t8);
        CheckLine("O", t3, t6, t9);
        CheckLine("O", t1, t5, t9);
        CheckLine("O", t3, t5, t7);

        if (t1 != "" && t2 != "" && t3 != "" &&
            t4 != "" && t5 != "" && t6 != "" &&
            t7 != "" && t8 != "" && t9 != "" &&
            msg.text == "")
        {
            msg.text = "It's a Draw!";
        }
    }

    void CheckLine(string player, string t1, string t2, string t3)
    {
        if (t1 == player && t2 == player && t3 == player && msg.text == "")
        {
            msg.text = "Winner: Player " + player;
            int score = int.Parse(player == "X" ? PlayerX.text : PlayerO.text);
            score++;
            if (player == "X") PlayerX.text = score.ToString();
            else PlayerO.text = score.ToString();
        }
    }

    public void ResetGame()
    {
        Text1.text = Text2.text = Text3.text = "";
        Text4.text = Text5.text = Text6.text = "";
        Text7.text = Text8.text = Text9.text = "";
        msg.text = "";
        isXTurn = true;
    }

    public void NewGame()
    {
        ResetGame();
        PlayerX.text = "0";
        PlayerO.text = "0";
    }
}

