using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

 
    public event Action<int> OnCellClicked;
    public event Action OnRestartKeyPressed;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

   
    public void CellClicked(int index)
    {
        OnCellClicked?.Invoke(index); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            OnRestartKeyPressed?.Invoke(); 
        }
    }
}

