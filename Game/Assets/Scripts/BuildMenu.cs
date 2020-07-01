using System.Collections;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public Texture sunImage;

    // Plant Prefabs
    public BuildInfo[] plants;

    public static BuildInfo current;

    void OnGUI() {
        GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = 30;

        // Begin Gui
        GUILayout.BeginArea(new Rect(Screen.width/2 - 100, 0, 900, 800));
        GUILayout.BeginHorizontal("box");

        // Draw the Sun
        GUILayout.Box(new GUIContent(MouseCollect.score.ToString(), sunImage));

        // Draw each Plant's BuildInfo
        foreach (BuildInfo bi in plants) {
            GUI.enabled = MouseCollect.score >= bi.price;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage))) {
                current = bi;
            }

        }

        // End Gui
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
