using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public class StreamData : ISaveData
    {
        string SavePath = Path.Combine(Application.dataPath, "StreamData.xyz");

        public void SaveData(PlayerData player)
        {
            using (StreamWriter _write = new StreamWriter(SavePath))
            {
                _write.WriteLine(player.PlayerName);
                _write.WriteLine(player.PlayerHealth);
                _write.WriteLine(player.PlayerPosition);
            }

        }

        public PlayerData Load()
        {
            PlayerData result = new PlayerData();

            if (!File.Exists(SavePath))
            {
                Debug.Log("File not exist!");
                return result;
            }

            using (StreamReader _reader = new StreamReader(SavePath))
            {
                result.PlayerName = _reader.ReadLine();
                result.PlayerHealth = Convert.ToInt32(_reader.ReadLine());
                //result.PlayerPosition = (Svect3)_reader.ReadLine();
            }

            return result;
        }
    }
}