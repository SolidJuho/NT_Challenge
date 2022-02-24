using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammignChallenge : MonoBehaviour
{
    /// <summary>
    /// In this programming challenge, you have to print out longest string without repeating characters
    /// </summary>

    void Start()
    {
        Debug.Log(GetLongest("nnawSS")); //Correct anwser nawS
        Debug.Log(GetLongest("asdsdghsdfASDSAD")); //Correct anwser ghsdfASD
    }

    private object GetLongest(string inputString)
    {
        throw new NotImplementedException();
    }
}
