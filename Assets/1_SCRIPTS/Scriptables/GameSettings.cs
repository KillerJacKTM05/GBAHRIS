using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SafeZone;

[CreateAssetMenu(fileName = "GameSettings", menuName = "DevelopmentSafeZone/Game/GameSettings", order = 1)]
public class GameSettings : BaseScriptable
{
    [Header("General")]
    public int ID = 0;
    public List<Level> levelList = new List<Level>();
    [Range(0, 600f)]public float realWorldTimeForEachGameHour = 300f;

    [Header("Player Specs")]
    [Range(0, 45f)] public float playerRotateSensivity = 33f;
    [Range(0, 45f)] public float playerMoveSpeed = 3f;
}
