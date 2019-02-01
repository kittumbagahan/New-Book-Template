﻿using SQLite4Unity3d;
using UnityEngine;
using System;
#if !UNITY_EDITOR
using System.Collections;
using System.IO;
#endif
using System.Collections.Generic;

using System.Threading;

public static class DataService
{

    public static SQLiteConnection _connection { private set; get; }

    public static void Open()
    {
        string DatabaseName; /* = PlayerPrefs.GetString("activeDatabase") == "" ? "tempDatabase.db" : PlayerPrefs.GetString("activeDatabase");*/
        DatabaseName = DbName();
        string dbPath = Application.persistentDataPath + "/" + DatabaseName;

        _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        //Debug.Log("Open Final PATH: " + dbPath);
    }

    public static void Open(string DatabaseName)
    {
        string dbPath = Application.persistentDataPath + "/" + DatabaseName;
        _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        Debug.Log("Open Final PATH: " + dbPath);
    }

    public static void Close()
    {
        _connection.Close();
        _connection.Dispose();
        GC.Collect();
        //Debug.Log("Close connection");
    }

    public static string DbName()
    {
        return PlayerPrefs.GetString("activeDatabase", "");
       

    }

    public static void SetDbName(string pDbName)
    {
        PlayerPrefs.SetString("activeDatabase", pDbName);
    }

    // public DataService(string DatabaseName)
    // {
    //     string dbPath = Application.persistentDataPath + "/" + DatabaseName;
    //   //#if UNITY_EDITOR
    //   //      var dbPath = string.Format (@"Assets/StreamingAssets/{0}", DatabaseName);
    //   //#else
    //   //        // check if file exists in Application.persistentDataPath
    //   //        var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);

    //   //        if (!File.Exists(filepath))
    //   //        {
    //   //            Debug.Log("Database not in Persistent path");
    //   //            // if it doesn't ->
    //   //            // open StreamingAssets directory and load the db ->

    //   //#if UNITY_ANDROID
    //   //            var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
    //   //            while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
    //   //            // then save to Application.persistentDataPath
    //   //            File.WriteAllBytes(filepath, loadDb.bytes);
    //   //#elif UNITY_IOS
    //   //                 var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
    //   //                // then save to Application.persistentDataPath
    //   //                File.Copy(loadDb, filepath);
    //   //#elif UNITY_WP8
    //   //                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
    //   //                // then save to Application.persistentDataPath
    //   //                File.Copy(loadDb, filepath);

    //   //#elif UNITY_WINRT
    //   //		var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
    //   //		// then save to Application.persistentDataPath
    //   //		File.Copy(loadDb, filepath);

    //   //#elif UNITY_STANDALONE_OSX
    //   //		var loadDb = Application.dataPath + "/Resources/Data/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
    //   //		// then save to Application.persistentDataPath
    //   //		File.Copy(loadDb, filepath);
    //   //#else
    //   //	var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
    //   //	// then save to Application.persistentDataPath
    //   //	File.Copy(loadDb, filepath);

    //   //#endif

    //   //            Debug.Log("Database written");
    //   //        }

    //   //        var dbPath = filepath;
    //   //#endif
    //       _connection = new SQLiteConnection (dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
    //       Debug.Log ("Final PATH: " + dbPath);

    //}


    public static IEnumerable<SubscriptionTimeModel> GetSubscription()
    {
        return _connection.Table<SubscriptionTimeModel>();
    }

    public static IEnumerable<BookModel> GetBooks()
    {
        return _connection.Table<BookModel>();
    }

    public static IEnumerable<ActivityModel> GetActivities()
    {
        return _connection.Table<ActivityModel>();
    }

    public static IEnumerable<SectionModel> GetSections()
    {
        return _connection.Table<SectionModel>();
    }

    public static IEnumerable<StudentModel> GetStudents()
    {
        return _connection.Table<StudentModel>();
    }

    public static IEnumerable<StudentActivityModel> GetStudentActivities()
    {
        return _connection.Table<StudentActivityModel>();
    }

    public static IEnumerable<StudentBookModel> GetStudentBooks()
    {
        return _connection.Table<StudentBookModel>();
    }


    public static Person CreatePerson()
    {
        var p = new Person
        {
            Name = "Johnny",
            Surname = "Mnemonic",
            Age = 21
        };
        _connection.Insert(p);
        return p;
    }
}
