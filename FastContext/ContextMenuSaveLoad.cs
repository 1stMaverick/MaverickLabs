using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MaverickLabs
{
    public class ContextMenuSaveLoad
    {
        public void SaveDictionary(string filePath, Dictionary<string, string> dictionary)
        {
            try
            {
                if (dictionary == null || dictionary.Count == 0)
                {
                    MessageBox.Show("Dictionary is empty, nothing to save.");
                    return;
                }

               // MessageBox.Show("Saving Dictionary: " + string.Join(", ", dictionary.Select(kv => kv.Key + "=" + kv.Value)));

                string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
                File.WriteAllText(filePath, json);

               // MessageBox.Show("Dictionary saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving dictionary: " + ex.Message);
            }
        }


        public Dictionary<string, string> LoadDictionary(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    //MessageBox.Show("Loaded Dictionary: " + string.Join(", ", dictionary.Select(kv => kv.Key + "=" + kv.Value)));

                    return dictionary;
                }
                else
                {
                    //MessageBox.Show("File not found.");
                    return new Dictionary<string, string>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dictionary: " + ex.Message);
                return new Dictionary<string, string>();
            }
        }
    }
}
