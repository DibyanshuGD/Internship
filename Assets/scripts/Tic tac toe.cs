using UnityEngine;
using UnityEngine.UI;
using System;

public class Tictactoe : MonoBehaviour
{
    Boolean checker;
    int plusone;

    public Text Text1 = null;
    public Text Text2 = null;
    public Text Text3 = null;
    public Text Text4 = null;
    public Text Text5 = null;
    public Text Text6 = null;
    public Text Text7 = null;
    public Text Text8 = null;
    public Text Text9 = null;

    public Text ResetGame = null;
    public Text NewGame = null;
    public Text msg = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public void score()
    {
        if (Text1.text == "X" && Text2.text == "X" && Text3.text == "X")
        {
            Text1.color = Color.red;
            Text2.color = Color.red;
            Text3.color = Color.red;
            msg.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (Text1.text == "X" && Text4.text == "X" && Text7.text == "X")
        {
            Text1.color = Color.blue;
            Text4.color = Color.blue;
            Text7.color = Color.blue;
            msg.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (Text1.text == "X" && Text5.text == "X" && Text9.text == "X")
        {
            Text1.color = Color.green;
            Text5.color = Color.green;
            Text9.color = Color.green;
            msg.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (Text3.text == "X" && Text5.text == "X" && Text7.text == "X")
        {
            Text3.color = Color.gray;
            Text5.color = Color.gray;
            Text7.color = Color.gray;
            msg.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (Text2.text == "X" && Text5.text == "X" && Text8.text == "X")
        {
            Text2.color = Color.yellow;
            Text5.color = Color.yellow;
            Text8.color = Color.yellow;
            msg.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (Text3.text == "X" && Text6.text == "X" && Text9.text == "X")
        {
            Text3.color = Color.cyan;
            Text6.color = Color.cyan;
            Text9.color = Color.cyan;
            msg.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (Text4.text == "X" && Text5.text == "X" && Text6.text == "X")
        {
            Text4.color = Color.green;
            Text5.color = Color.green;
            Text6.color = Color.green;
            msg.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (Text7.text == "X" && Text8.text == "X" && Text9.text == "X")
        {
            Text7.color = Color.blue;
            Text8.color = Color.blue;
            Text9.color = Color.blue;
            msg.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        //===================================PlayerO======================================================//
        if (Text1.text == "O" && Text2.text == "O" && Text3.text == "O")
        {
            Text1.color = Color.red;
            Text2.color = Color.red;
            Text3.color = Color.red;
            msg.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (Text1.text == "O" && Text4.text == "O" && Text7.text == "O")
        {
            Text1.color = Color.blue;
            Text4.color = Color.blue;
            Text7.color = Color.blue;
            msg.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (Text1.text == "O" && Text5.text == "O" && Text9.text == "O")
        {
            Text1.color = Color.green;
            Text5.color = Color.green;
            Text9.color = Color.green;
            msg.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (Text3.text == "O" && Text5.text == "O" && Text7.text == "O")
        {
            Text3.color = Color.gray;
            Text5.color = Color.gray;
            Text7.color = Color.gray;
            msg.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (Text2.text == "O" && Text5.text == "O" && Text8.text == "O")
        {
            Text2.color = Color.yellow;
            Text5.color = Color.yellow;
            Text8.color = Color.yellow;
            msg.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (Text3.text == "O" && Text6.text == "O" && Text9.text == "O")
        {
            Text3.color = Color.cyan;
            Text6.color = Color.cyan;
            Text9.color = Color.cyan;
            msg.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (Text4.text == "O" && Text5.text == "O" && Text6.text == "O")
        {
            Text4.color = Color.green;
            Text5.color = Color.green;
            Text6.color = Color.green;
            msg.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (Text7.text == "O" && Text8.text == "O" && Text9.text == "O")
        {
            Text7.color = Color.blue;
            Text8.color = Color.blue;
            Text9.color = Color.blue;
            msg.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (Text1.text != "" && Text2.text != "" && Text3.text != "" &&
    Text4.text != "" && Text5.text != "" && Text6.text != "" &&
    Text7.text != "" && Text8.text != "" && Text9.text != "" &&
    msg.text == "") // No one has won yet
        {
            msg.text = "It's a Draw!";
        }
    }
    public void Text1_Click()
    {

        if (checker == false)
        {
            Text1.text = "X";
            checker = true;
        }
        else
        {
            Text1.text = "O";
            checker = false;
        }
        score();
    }
    public void Text2_Click()
    {

        if (checker == false)
        {
            Text2.text = "X";
            checker = true;
        }
        else
        {
            Text2.text = "O";
            checker = false;
        }
        score();
    }
    public void Text3_Click()
    {

        if (checker == false)
        {
            Text3.text = "X";
            checker = true;
        }
        else
        {
            Text3.text = "O";
            checker = false;
        }
        score();
    }
    public void Text4_Click()
    {

        if (checker == false)
        {
            Text4.text = "X";
            checker = true;
        }
        else
        {
            Text4.text = "O";
            checker = false;
        }
        score();
    }
    public void Text5_Click()
    {

        if (checker == false)
        {
            Text5.text = "X";
            checker = true;
        }
        else
        {
            Text5.text = "O";
            checker = false;
        }
        score();
    }
    public void Text6_Click()
    {

        if (checker == false)
        {
            Text6.text = "X";
            checker = true;
        }
        else
        {
            Text6.text = "O";
            checker = false;
        }
        score();
    }
    public void Text7_Click()
    {

        if (checker == false)
        {
            Text7.text = "X";
            checker = true;
        }
        else
        {
            Text7.text = "O";
            checker = false;
        }
        score();
    }
    public void Text8_Click()
    {

        if (checker == false)
        {
            Text8.text = "X";
            checker = true;
        }
        else
        {
            Text8.text = "O";
            checker = false;
        }
        score();
    }
    public void Text9_Click()
    {

        if (checker == false)
        {
            Text9.text = "X";
            checker = true;
        }
        else
        {
            Text9.text = "O";
            checker = false;
        }
        score();
    }
    public void ResetGame_Click()
    {
        Text1.text = "";
        Text2.text = "";
        Text3.text = "";
        Text4.text = "";
        Text5.text = "";
        Text6.text = "";
        Text7.text = "";
        Text8.text = "";
        Text9.text = "";

        Text1.color = Color.black;
        Text2.color = Color.black;
        Text3.color = Color.black;
        Text4.color = Color.black;
        Text5.color = Color.black;
        Text6.color = Color.black;
        Text7.color = Color.black;
        Text8.color = Color.black;
        Text9.color = Color.black;
    }
    public void NewGame_Click()
    {
        ResetGame_Click();
        txtPlayerX.text = "";
        txtPlayerO.text = "";
    }

}
