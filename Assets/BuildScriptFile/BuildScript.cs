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
        // �r���h����V�[���̃p�X�̔z����쐬
        string[] scenePaths = new string[]
        {
            "Assets/Scenes/SampleScene.unity",
            "Assets/Scenes/Title.unity",
        };

        // �r���h�̐ݒ���s��
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenePaths; // �r���h����V�[���̃p�X���w��
        buildPlayerOptions.locationPathName = "D:/SelfStudyUnity/SelfStudyUnity_exe"; // �r���h���ʂ̕ۑ�����w��
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64; // �r���h�^�[�Q�b�g���w��

        // �r���h�����s
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
