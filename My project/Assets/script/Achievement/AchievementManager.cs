using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager instance;
    public List<Achievement> achievements;

    public Text[] AchievementTexts = new Text[4];

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void AddProgressList(string achievementName, int amount)
    {
        Achievement achievement = achievements.Find (a => a.name == achievementName);
        if(achievement == null)
        {
            achievement.AddProgress(amount);
        }
    }


    public void AddAchivement(Achievement achievement)
    {
        achievements.Add(achievement);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateAcheviementUI()
    {
        AchievementTexts[0].text = achievements[0].name;
        AchievementTexts[1].text = achievements[0].Description;
        AchievementTexts[3].text = $"{achievements[0].currentProgress}/{achievements[0].goal}";
        AchievementTexts[3].text = achievements[0].isUnlocked ? "달성" : "미달성";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AddProgressList("도약", 1);
        }
    }
}
