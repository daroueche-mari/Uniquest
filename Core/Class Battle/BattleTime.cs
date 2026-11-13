using System;
using System.Threading.Tasks;
using TMPro;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BattleTime : MonoBehaviour
{
    public GameObject BattleLog;
    public GameObject AttackBtn;
    public GameObject MagicBtn;
    public GameObject ObjectBtn;
    public GameObject AbandoneBtn;
    public GameObject AttackOption;
    public GameObject MagicOption;
    public GameObject ObjectOption;
    public Button AttackOne;
    public Button AttackTwo;
    public Button AttackThree;
    public Button AttackFour;
    public Button MagicOne;
    public Button MagicTwo;
    public Button MagicThree;
    public Button MagicFour;
    public Button ObjectOne;
    public Button ObjectTwo;
    public Button ObjectThree;
    public Button ObjectFour;
    public TextMeshProUGUI logTxt;
    public GameObject BattlePanel;
    public GameObject GamePanel;
  
    public void Awake()
    {
        logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
        AttackOne.onClick.AddListener(TurnPlayerAttackOne);
        AttackTwo.onClick.AddListener(TurnPlayerAttackTwo);
        AttackThree.onClick.AddListener(TurnPlayerAttackThree);
        AttackFour.onClick.AddListener(TurnPlayerAttackFour);
        //MagicOne.onClick.AddListener(TurnPlayerMagicOne);
        //MagicTwo.onClick.AddListener(TurnPlayerMagicTwo);
        //MagicThree.onClick.AddListener(TurnPlayerMagicThree);
        //MagicFour.onClick.AddListener(TurnPlayerMagicFour);
        //ObjectOne.onClick.AddListener(TurnPlayerObjectOne);
        //ObjectTwo.onClick.AddListener(TurnPlayerObjectTwo);
        //ObjectThree.onClick.AddListener(TurnPlayerObjectThree);
        //ObjectFour.onClick.AddListener(TurnPlayerObjectFour);
    }

    public async void OnEnable()
    {
        AttackBtn.SetActive(false);
        MagicBtn.SetActive(false);
        ObjectBtn.SetActive(false);
        AbandoneBtn.SetActive(false);
        PlayerCharacter.myPlayerChar[0].Health = 100;
        EnemyCharacter.myEnemyChar[0].Health = 100;
        logTxt.text = "Debut du combat";
        await Task.Delay(1000);
        AttackBtn.SetActive(true);
        MagicBtn.SetActive(true);
        ObjectBtn.SetActive(true);
        AbandoneBtn.SetActive(true);
        WhoPlaying(1);
    }

  
    public async Task<bool> WhoIsWinner()
    {
        var loot = 0;
        var xpwon = 0;

        if(EnemyCharacter.myEnemyChar[0].Level >= 10)
        {
            loot = 300;
            xpwon = 50;
        } else if (EnemyCharacter.myEnemyChar[0].Level >= 5)
        {
            loot = 500;
            xpwon = 300;
        }
        else if (EnemyCharacter.myEnemyChar[0].Level >= 1)
        {
            loot = 900;
            xpwon = 1000;
        }
        // Defeat
        if (PlayerCharacter.myPlayerChar[0].Health == 0)
        {
            logTxt.text = "Vous avez perdu !";
            PlayerRessource.Money -= loot;
            await Task.Delay(1800);
            logTxt.text = "Vous avez perdu :" + loot + " or";
            await Task.Delay(1800);
            OnEnable();
            BattlePanel.SetActive(false);
            GamePanel.SetActive(true);
            return true;
        
          // Victory
        } else if(EnemyCharacter.myEnemyChar[0].Health == 0)
        {
            logTxt.text = "Vous avez gagné !";
            PlayerRessource.Money += loot;
            PlayerRessource.Experience += xpwon;
            if (PlayerRessource.UpLvl())
            {
                await Task.Delay(1100);
                logTxt.text = "Vous avez monter de un niveau";
            }
            await Task.Delay(1500);
            logTxt.text = "Vous avez obtenu : " + xpwon + " " + " xp" + " " + loot + " " + " or";
            await Task.Delay(1500);
            OnEnable();
            BattlePanel.SetActive(false);
            GamePanel.SetActive(true);
            return true;
        }
        return false;
    }

    public async void WhoPlaying(int turn)
    {
        if (await WhoIsWinner()) return;

        if (turn == 1)
        {
            AttackBtn.SetActive(true);
            MagicBtn.SetActive(true);
            ObjectBtn.SetActive(true);
            AbandoneBtn.SetActive(true);   
            logTxt.text = "C'est à votre tour.";

        }
        else if (turn == 2)
        {   
            TurnEnemy();
        }
    }

    async public void TurnEnemy()
    {
        
        AttackOption.SetActive(false);
        MagicOption.SetActive(false);
        ObjectOption.SetActive(false);
        AttackBtn.SetActive(false);
        MagicBtn.SetActive(false);
        ObjectBtn.SetActive(false);
        AbandoneBtn.SetActive(false);
        await Task.Delay(1800);
        logTxt.text = "L'ennemi attaque et utilise :";
        await Task.Delay(1800);
        logTxt.text = AttackWithoutEffect.attackNoEffect[0].Name;
        AttackWithoutEffect.DamageToPlayer(0);
        await Task.Delay(1800);
        logTxt.text = "Les vies du joueur sont à : " + PlayerCharacter.myPlayerChar[0].Health;
        // logic pour la baisse de vie et d'energie
        await Task.Delay(1800);
        if (await WhoIsWinner()) return;
        WhoPlaying(1);

    }

    async public void TurnPlayerAttackOne()
    {
        AttackOption.SetActive(false);
        AttackBtn.SetActive(false);
        MagicBtn.SetActive(false);
        ObjectBtn.SetActive(false);
        AbandoneBtn.SetActive(false);
        logTxt.text = "Le joueur attaque avec :";
        await Task.Delay(1800);
        logTxt.text = AttackWithoutEffect.attackNoEffect[0].Name;
        AttackWithoutEffect.DamageToEnemy(0);
        await Task.Delay(1800);
        logTxt.text = "Les vies de l'adversaire sont à : " + EnemyCharacter.myEnemyChar[0].Health;
        await Task.Delay(1800);
        if (await WhoIsWinner()) return;
        logTxt.text = "Tour de l'ennemi !";        
        WhoPlaying(2);
    }
    public async void TurnPlayerAttackTwo()
    {
        AttackOption.SetActive(false);
        AttackBtn.SetActive(false);
        MagicBtn.SetActive(false);
        ObjectBtn.SetActive(false);
        AbandoneBtn.SetActive(false);
        logTxt.text = "Le joueur attaque avec :";
        await Task.Delay(1800);
        logTxt.text = AttackWithoutEffect.attackNoEffect[0].Name;
        AttackWithoutEffect.DamageToEnemy(0);
        await Task.Delay(1800);
        logTxt.text = "Les vies de l'adversaire sont à : " + EnemyCharacter.myEnemyChar[0].Health;
        await Task.Delay(1800);
        if (await WhoIsWinner()) return;
        logTxt.text = "Tour de l'ennemi !";
        WhoPlaying(2);
    }
    public async void TurnPlayerAttackThree()
    {
        AttackOption.SetActive(false);
        AttackBtn.SetActive(false);
        MagicBtn.SetActive(false);
        ObjectBtn.SetActive(false);
        AbandoneBtn.SetActive(false);
        logTxt.text = "Le joueur attaque avec :";
        await Task.Delay(1800);
        logTxt.text = AttackWithoutEffect.attackNoEffect[0].Name;
        AttackWithoutEffect.DamageToEnemy(0);
        await Task.Delay(1800);
        logTxt.text = "Les vies de l'adversaire sont à : " + EnemyCharacter.myEnemyChar[0].Health;
        await Task.Delay(1800);
        if (await WhoIsWinner()) return;
        logTxt.text = "Tour de l'ennemi !";
        WhoPlaying(2);
    }
    public async void TurnPlayerAttackFour()
    {
        AttackOption.SetActive(false);
        AttackBtn.SetActive(false);
        MagicBtn.SetActive(false);
        ObjectBtn.SetActive(false);
        AbandoneBtn.SetActive(false);
        logTxt.text = "Le joueur attaque avec :";
        await Task.Delay(1800);
        logTxt.text = AttackWithoutEffect.attackNoEffect[0].Name;
        AttackWithoutEffect.DamageToEnemy(0);
        await Task.Delay(1800);
        logTxt.text = "Les vies de l'adversaire sont à : " + EnemyCharacter.myEnemyChar[0].Health;
        await Task.Delay(1800);
        if (await WhoIsWinner()) return;
        logTxt.text = "Tour de l'ennemi !";
        WhoPlaying(2);
    }
    //public void TurnPlayerMagicOne()
    //{
    //    TextMeshProUGUI logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
    //    logTxt.text = "Le joueur attaque";
    //    // logic pour la baisse de vie et d'energie
    //    WhoPlaying(2);
    //}
    //public void TurnPlayerMagicTwo()
    //{
    //    TextMeshProUGUI logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
    //    logTxt.text = "Le joueur attaque";
    //    // logic pour la baisse de vie et d'energie
    //    WhoPlaying(2);
    //}
    //public void TurnPlayerMagicThree()
    //{
    //    TextMeshProUGUI logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
    //    logTxt.text = "Le joueur attaque";
    //    // logic pour la baisse de vie et d'energie
    //    WhoPlaying(2);
    //}
    //public void TurnPlayerMagicFour()
    //{
    //    TextMeshProUGUI logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
    //    logTxt.text = "Le joueur attaque";
    //    // logic pour la baisse de vie et d'energie
    //    WhoPlaying(2);
    //}
    //public void TurnPlayerObjectOne()
    //{
    //    TextMeshProUGUI logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
    //    logTxt.text = "Le joueur attaque";
    //    // logic pour la baisse de vie et d'energie
    //    WhoPlaying(2);
    //}
    //public void TurnPlayerObjectTwo()
    //{
    //    TextMeshProUGUI logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
    //    logTxt.text = "Le joueur attaque";
    //    // logic pour la baisse de vie et d'energie
    //    WhoPlaying(2);
    //}
    //public void TurnPlayerObjectThree()
    //{
    //    TextMeshProUGUI logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
    //    logTxt.text = "Le joueur attaque";
    //    // logic pour la baisse de vie et d'energie
    //    WhoPlaying(2);
    //}
    //public void TurnPlayerObjectFour()
    //{
    //    TextMeshProUGUI logTxt = BattleLog.GetComponent<TextMeshProUGUI>();
    //    logTxt.text = "Le joueur attaque";
    //    // logic pour la baisse de vie et d'energie
    //    WhoPlaying(2);
    //}





}
