using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // 에디터에서는 Play 모드 종료
        #else
            Application.Quit(); // 빌드된 앱에서는 게임 종료
        #endif
    }
}

