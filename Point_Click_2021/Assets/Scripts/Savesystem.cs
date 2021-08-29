using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savesystem 
{
    //private static readonly string SAVE_FOLDER = Application.dataPath + "/Saves/";
    private static readonly string GameOne = Application.dataPath + "/Saves/Game_1/";
    private static readonly string GameTwo = Application.dataPath + "/Saves/Game_2/";
    private static readonly string GameThree = Application.dataPath + "/Saves/Game_3/";
    private const string SAVE_EXTENSION = "txt";

    private static string G_One = PlayerPrefs.GetString("GameNameKey_1");
    private static string G_Two = PlayerPrefs.GetString("GameNameKey_2");
    private static string G_Three = PlayerPrefs.GetString("GameNameKey_3") ;


    public static void Init(){
        //Prüfen ob Ordner existiert
        if(!Directory.Exists(GameOne) || !Directory.Exists(GameTwo) || !Directory.Exists(GameThree)){
            //Neuer Ordner anlegen
            Directory.CreateDirectory(GameOne);
            Directory.CreateDirectory(GameTwo);
            Directory.CreateDirectory(GameThree);
        }/*
        if(!Directory.Exists(GameTwo)){
            //Neuer Ordner anlegen
            Directory.CreateDirectory(GameTwo);
        }
        if(!Directory.Exists(GameThree)){
            //Neuer Ordner anlegen
            Directory.CreateDirectory(GameThree);
        }*/
    }

    public static void Save(string SaveString) 
    {   
        int num = 1; 
        while(File.Exists(GameOne + "save_" + num + "." + SAVE_EXTENSION)){
            num++;
        }
           File.WriteAllText(GameOne + "save_" + num +"." + SAVE_EXTENSION, SaveString); 
    }

     public static string Load() {
        DirectoryInfo directoryInfo = new DirectoryInfo(GameOne);
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
