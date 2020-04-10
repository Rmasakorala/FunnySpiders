using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class CustomNetworkHUD : NetworkManager
{
    public void StartHosting()
    {
        base.StartHost();
    }

    private void OnEnable()
    {
        RefreshMatches();
    }

    private void RefreshMatches()
    {
        if (matchMaker == null)
        {
            StartMatchMaker();
        }
        matchMaker.ListMatches(0, 10, "", true, 0, 0, HandleListMatchesComplete());
    }

    
    private NetworkMatch.DataResponseDelegate<List<MatchInfoSnapshot>> HandleListMatchesComplete()
    {
        throw new NotImplementedException();
    }
    
    /*
    private void HandleListMatchesComplete(bool success, string extendedinfo, List<MatchInfoSnapshot> responsedata)
    {
        throw new NotImplementedException();
    }
    */
}
