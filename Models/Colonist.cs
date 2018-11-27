namespace ColonyGaming_Angular_Web_API.Models
{
    public class Colonist {
    public string id;
    public string name;
    public string urlpath;
    public string game;
    public string avatar;
    public string status;
    public int viewerCount;
    public bool isLive;

    public Colonist(){}
    public Colonist(string id, string name, string urlpath, string game, string avatar, string status, int viewerCount, bool isLive) {
        this.id = id;
        this.name = name;
        this.urlpath = urlpath;
        this.game = game;
        this.avatar = avatar;
        this.status = status;
        this.viewerCount = viewerCount;
        this.isLive = isLive;
    }
  }
}