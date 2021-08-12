using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savesystem 
{
    private static readonly string SAVE_FOLDER = Application.dataPath + "/Saves/";
    private const string SAVE_EXTENSION = "txt";

    public static void Init(){
        //Prüfen ob Ordner existiert
        if(!Directory.Exists(SAVE_FOLDER)){
            //Neuer Ordner anlegen
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }

    public static void Save(string SaveString) {
        int saveNumber = 1;
        while(File.Exists(SAVE_FOLDER + "save_" + saveNumber + "." + SAVE_EXTENSION)){
            saveNumber++;
        }
        File.WriteAllText(SAVE_FOLDER + "save_" + saveNumber + "." + SAVE_EXTENSION, SaveString);
    }

     public static string Load() {
        DirectoryInfo directoryInfo = new DirectoryInfo(SAVE_FOLDER);
        // Get all save files
        FileInfo[] saveFiles = directoryInfo.GetFiles("*." + SAVE_EXTENSION);
        // Cycle through all save files and identify the most recent one
        FileInfo mostRecentFile = null;
        foreach (FileInfo fileInfo in saveFiles) {
            if (mostRecentFile == null) {
                mostRecentFile = fileInfo;
            } else {
                if (fileInfo.LastWriteTime > mostRecentFile.LastWriteTime) {
                    mostRecentFile = fileInfo;
                }
            }
        }

        // If theres a save file, load it, if not return null
        if (mostRecentFile != null) {
            string saveString = File.ReadAllText(mostRecentFile.FullName);
            return saveString;
        } else {
            return null;
        }
    }
}
