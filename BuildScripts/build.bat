@echo off
REM Unity Editorの実行ファイルへのパス
set UNITY_PATH="C:\Program Files\Unity\Hub\Editor\2021.3.9f1\Editor\Unity.exe"

REM Unityプロジェクトのパス
set PROJECT_PATH="D:\SelfStudyUnity\SelfStudyUnity2"

REM Unity Editorをバッチモードで起動し、プロジェクトを開く
%UNITY_PATH% -batchmode -projectPath %PROJECT_PATH% -executeMethod BuildScript.AutoBuild

REM 終了コードを取得して、Jenkinsに渡す
exit /b %errorlevel%