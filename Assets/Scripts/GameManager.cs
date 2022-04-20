using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager
{
    private static GameManager instance;

    private List<GameObject> trashCans = new List<GameObject>();
    public List<GameObject> TranshCan { get { return trashCans;} }
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

    public void AddTrashCans(GameObject newTranshcan)
    {
        trashCans.Add(newTranshcan);
    }
    public void RemoveTrashCans(GameObject removedTranshcan)
    {
        //int index = trashCans.IndexOf(removedTranshcan);
        trashCans.Remove(removedTranshcan);
    }


}
