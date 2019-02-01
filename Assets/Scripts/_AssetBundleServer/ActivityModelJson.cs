﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActivityModelJson {

    public int Id; //Auto Inc
    public int BookId;
    public string Description;
    public string Module;
    public int Set;

    public ActivityModelJson(int bookId, string desc, Module module, int set)
    {
       
        BookId = bookId;
        Description = desc;
        Module = module.ToString();
        Set = set;

    }

    public override string ToString()
    {
        return string.Format("[ActivityModel: Id={0}, BookId={1}, Description={2}, Module={3}, Set={4}",
           Id, BookId, Description, Module, Set);
    }
}
