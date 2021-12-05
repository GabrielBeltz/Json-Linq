using System.Collections.Generic;

[System.Serializable]
public class player
{
    public int id;
    public string name, email, username;
    public int points, platformIndex;
    public string platformName;
    public int countryIndex;
    public string countryName;
    public List<hero> heroes;
}
