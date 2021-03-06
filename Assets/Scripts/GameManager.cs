using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager 
{
    private static GameManager instance;
    private List<GameObject> trashCans = new List<GameObject>();
    private List<GameObject> goalPoints = new List<GameObject>();
    public List<GameObject> TrashCans { get { return trashCans; } }
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
    public void AddTrashCan(GameObject tempTrashCan)
    {
        TrashCans.Add(tempTrashCan);
    }
    public void RemoveTrashCan(GameObject tempTrashCan)
    {
        int index = trashCans.IndexOf(tempTrashCan);
        GameObject.Destroy(trashCans[index]);
        TrashCans.RemoveAt(index);
    }
}