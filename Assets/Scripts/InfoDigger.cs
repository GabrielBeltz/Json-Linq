using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoDigger : MonoBehaviour
{
    public playersList highscores, herolessPlayers, players;
    public string mostPickedClass, leastPickedClass;
    public CountryList Country;
    public Text highscoresText, herolessPlayersText;

    void Start()
    {
        string countryText = File.ReadAllText(Application.dataPath + "/country.json");
        Country = JsonUtility.FromJson<CountryList>(countryText);
        string playersText = File.ReadAllText(Application.dataPath + "/data3.json");
        players = JsonUtility.FromJson<playersList>(playersText);
        Question1();
        Question2();
        Question3();
        Question4();
        Question5();
        Question6();
    }

    public void Question1()
    {
        highscores.players = players.players.OrderByDescending(t => t.points).Take(3).ToList();
        foreach (var item in highscores.players)
        {
            highscoresText.text += $"{item.name}: {item.points}{Environment.NewLine}";
        }
    }

    public void Question2()
    {
        herolessPlayers.players = players.players.Where(t => t.heroes.Count == 0).ToList();
        herolessPlayers.players = herolessPlayers.players.OrderBy(t => t.countryName).ToList();
        foreach (var item in herolessPlayers.players)
        {
            herolessPlayersText.text += $"{item.name}({item.countryName}){Environment.NewLine}";
        }
    }

    public void Question3()
    {
        //https://www.youtube.com/watch?v=6GfqT-HKsY8
        // 
    }

    public void Question4()
    {
        //https://www.youtube.com/watch?v=6GfqT-HKsY8
    }

    public void Question5()
    {
        //https://www.youtube.com/watch?v=6GfqT-HKsY8
    }

    public void Question6()
    {
        //https://www.youtube.com/watch?v=6GfqT-HKsY8
    }
}

[System.Serializable]
public class playersList
{
    public List<player> players;
}

[System.Serializable]
public class CountryList
{
    public List<string> country;
}