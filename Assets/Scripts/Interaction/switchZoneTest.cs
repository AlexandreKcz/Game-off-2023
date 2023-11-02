using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchZoneTest : Interactable
{
    [SerializeField] private Transform _spawnTeleport;
    [SerializeField] private PlayerController _player;

    public override void interaction(GameObject source)
    {
        Debug.Log("switch zone");
        _player.TeleportPlayer(_spawnTeleport.position);
    }
}
