﻿namespace WinFormsApp3;
using System.Diagnostics;
using System.Text.Json;

public static class Functions
{
    public static void WriteUserTojson(List<User> users,string text)
    {
        JsonSerializerOptions op = new()
        {
            WriteIndented = true
        };
        string json = JsonSerializer.Serialize(users,op);
        File.WriteAllText(text, json);
    }
    public static List<User> ReadUserToJson(string txt)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonstring = "";
        jsonstring = File.ReadAllText(txt);
        return JsonSerializer.Deserialize<List<User>>(jsonstring, options);
    }
}
