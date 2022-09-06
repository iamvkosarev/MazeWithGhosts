
using System;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _cameraPoint;
    [SerializeField] private MovementManager _movementManager;
    private void Awake()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        var playerGO = Instantiate(_player);
        _cameraPoint.parent = playerGO.transform;
        _cameraPoint.localPosition = Vector3.zero;
        _movementManager.playerBaseMove = playerGO.GetComponent<BaseMove>();
    }
}
