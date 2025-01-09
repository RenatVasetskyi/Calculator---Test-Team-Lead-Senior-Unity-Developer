using Architecture.Services.Interfaces;
using UnityEngine;

namespace Architecture.Services
{
    public class SaveService : ISaveService
    {
        public void SaveInt(string saveId, int value)
        {
            PlayerPrefs.SetInt(saveId, value);
            PlayerPrefs.Save();
        }

        public void SaveBool(string saveId, bool value)
        {
            PlayerPrefs.SetInt(saveId, (value ? 1 : 0));
            PlayerPrefs.Save();
        }

        public void SaveFloat(string saveId, float value)
        {
            PlayerPrefs.SetFloat(saveId, value);
            PlayerPrefs.Save();
        }

        public void SaveString(string saveId, string value)
        {
            PlayerPrefs.SetString(saveId, value);
            PlayerPrefs.Save();
        }
        
        public int LoadInt(string saveId)
        {
            return PlayerPrefs.GetInt(saveId);
        }

        public bool LoadBool(string saveId)
        {
            return (PlayerPrefs.GetInt(saveId) != 0);
        }

        public float LoadFloat(string saveId)
        {
            return PlayerPrefs.GetFloat(saveId);
        }

        public string LoadString(string saveId)
        {
            return PlayerPrefs.GetString(saveId);
        }

        public bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }

        public void DeleteKey(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }
    }
}