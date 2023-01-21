using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private ClickerZone clickerZone;

    public int count;

    public event UnityAction<int> scoreChanged;

    private void OnEnable()
    {
        clickerZone.Click += OnClick;
    }

    private void OnDisable()
    {
        clickerZone.Click -= OnClick;
    }

    private void OnClick()
    {
        count++;
        scoreChanged.Invoke(count);
    }
}
