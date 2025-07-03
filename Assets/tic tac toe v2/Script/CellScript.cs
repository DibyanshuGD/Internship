using UnityEngine;

public class CellScript : MonoBehaviour
{
    public int index;

    public void OnClick()
    {
        InputManager.Instance.CellClicked(index); 
    }
}
