using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public static void AutoBuild()
    {
        // ビルドするシーンのパスの配列を作成
        string[] scenePaths = new string[]
        {
            "Assets/Scenes/SampleScene.unity",
            "Assets/Scenes/Title.unity",
        };

        // ビルドの設定を行う
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenePaths; // ビルドするシーンのパスを指定
        buildPlayerOptions.locationPathName = "D:/SelfStudyUnity/SelfStudyUnity_exe"; // ビルド結果の保存先を指定
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64; // ビルドターゲットを指定

        // ビルドを実行
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
