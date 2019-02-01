﻿using UnityEngine;
using System.Collections;

public class ActivitySelectionManager : MonoBehaviour {
    
    [SerializeField]
    GameObject canvas;

    SceneLoader sl;

	void Start () {
        canvas = GameObject.Find("Canvas_UI_New");
        //use for going back to active storybook main page
        sl = canvas.GetComponent<SceneLoader>();
        sl.SceneToLoad = StoryBookSaveManager.ins.GetBookScene();
        sl.IsAssetBundle = AssetBundleInfo.BookScene.isAssetBundle;
        sl.VersionKey = AssetBundleInfo.BookScene.versionKey;
        sl.UrlKey = AssetBundleInfo.BookScene.urlKey;

        EmptySceneLoader.ins.isAssetBundle = true;
        EmptySceneLoader.ins.unloadAll = false;
        EmptySceneLoader.ins.unloadUrl = PlayerPrefs.GetString("ActivitySelection_url_key");
        EmptySceneLoader.ins.unloadVersion = PlayerPrefs.GetInt("ActivitySelection_version_key");
        

        Debug.Log("CHECK OUT FOR THIS");
		BG_Music.ins.SetVolume(0.5f);

	}

}
