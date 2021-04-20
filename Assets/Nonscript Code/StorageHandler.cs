using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

// based off of https://forum.unity.com/threads/simple-local-data-storage.468936/
// todo: harden
// todo: singleton? locking?

public class StorageHandler
{
    public static bool DeleteData(string fileName)
    {
        string FullFilePath = Application.persistentDataPath + "/" + fileName;
        if (File.Exists(FullFilePath))
        {
            File.Delete(FullFilePath);
            return true;
        }

        return false;
    }

    public static void SaveData(object objectToSave, string fileName)
    {
        string FullFilePath = Application.persistentDataPath + "/" + fileName;
        BinaryFormatter Formatter = new BinaryFormatter();
        FileStream fileStream = new FileStream(FullFilePath, FileMode.Create);
        Formatter.Serialize(fileStream, objectToSave);
        fileStream.Close();
    }

    public static T LoadOrCreateData<T>(string fileName) where T : class, new()
    {
        T loadedT = LoadData<T>(fileName);
        if (loadedT != null)
        {
            return loadedT;
        }

        return new T();
    }

    public static T LoadData<T>(string fileName) where T : class
    {
        string FullFilePath = Application.persistentDataPath + "/" + fileName;
        if (File.Exists(FullFilePath))
        {
            BinaryFormatter Formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(FullFilePath, FileMode.Open);
            object obj = Formatter.Deserialize(fileStream);
            fileStream.Close();

            return (T)obj;
        }

        return null;
    }
}