using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObstacleMap", menuName = "ScriptableObjects/CreateObstacleMapObject", order = 1)]
public class isBlockedArray : ScriptableObject
{
    public bool[] isBlocked = new bool[100];

    //get the correct blocked bool wrt i,j values
    public bool getBlocked(int i , int j) { 
        return isBlocked[i * 10 + j];
    }

    //set the correct blocked bool wrt i,j values
    public void setBlocked(int i , int j, bool value) {
        isBlocked[i * 10 + j] = value; 
    }
}
