using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class saveSystem
{
    //save the player data inside of player.sav file that contains binary
    public static void SavePlayer(movement player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        save data = new save(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    //loads the file with the player data from player.sav file that contains binary
    public static save loadPlayer()
    {
        string path = Application.persistentDataPath + "/player.sav";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path,FileMode.Open);
            save data = formatter.Deserialize(stream) as save;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found");
            return null;
        }
    }
}
