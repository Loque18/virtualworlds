using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Manager/GameSettings")]
public class GameSettings : ScriptableObject
{
    public string GameVersion = "0.0.0";

    public string Nickname = "";

    private void OnEnable()
    {
        Nickname = "guest" + Random.Range(0, 9999).ToString();
    }




}
