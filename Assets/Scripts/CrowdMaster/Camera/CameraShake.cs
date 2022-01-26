using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private PlayerStateMachine _player;
    [SerializeField] private float _speed;
    [SerializeField] private int _range;

    private Coroutine _coroutine;

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}
