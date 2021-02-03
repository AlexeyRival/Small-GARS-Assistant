using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class program : MonoBehaviour
{

    class player {
        public string name;
        public int money;
        public int citypoints;
        public int armypoints;
        public int cityes;
        public int ports;
        public int artifacts;
        public int guilds;
        public int undergrounds;
        public player(string name) {
            this.name = name;
        }
        public void addmoney()
        {
            money++;
        }
        public void takemoney()
        {
            money--;
        }
        public void addcitypoints()
        {
            citypoints++;
        }
        public void takecitypoints()
        {
            citypoints--;
        }
        public void buycitypoints()
        {
            if (money >= 3)
            {
                money -= 3;
                citypoints++;
            }
        }
        public void addarmypoints()
        {
            armypoints++;
        }
        public void takearmypoints()
        {
            armypoints--;
        }
        public void buyarmypoints()
        {
            if (money >= 2)
            {
                money -= 2;
                armypoints++;
            }
        }
        public void addcityes()
        {
            cityes++;
        }
        public void takecityes()
        {
            cityes--;
        }
        public void buycity()
        {
            if (citypoints >= 5)
            {
                citypoints -= 5;
                cityes++;
            }
        }
        public void addports()
        {
            ports++;
        }
        public void takeports()
        {
            ports--;
        }
        public void buyport()
        {
            if (citypoints >= 3)
            {
                citypoints -= 3;
                ports++;
            }
        }
        public void addartifacts()
        {
            artifacts++;
        }
        public void takeartifacts()
        {
            artifacts--;
        }
        public void buyartifact()
        {
            if (citypoints >= 1)
            {
                citypoints -= 1;
                artifacts++;
            }
        }
        public void addguilds()
        {
            guilds++;
        }
        public void takeguilds()
        {
            guilds--;
        }
        public void buyguild()
        {
            if (citypoints >= 3)
            {
                citypoints -= 3;
                guilds++;
            }
        }
        public void buyunderground()
        {
            if (citypoints >= 3)
            {
                citypoints -= 3;
            }
        }
        public void addunderground()
        {
            undergrounds++;
        }
        public void takeunderground()
        {
            undergrounds--;
        }
        public void calculatemoney() {
            money += (2 * cityes) + (2 * ports) + (2 * artifacts) + guilds - (undergrounds * 4);
        }
    }
    player player0;
    player player1;
    player player2;
    private int d20 = 0;
    private int actualevent=0;
    private readonly string[] events = {"Эпидемия", "Нападения зверя", "Нашествие крыс", "Народные волнения", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    void Start()
    {
        player0 = new player("Алексей");
        player1 = new player("Гин");
        player2 = new player("Варвара");
    }
    private void OnGUI()
    {
        GUI.Box(new Rect(0,0,130,25), player0.name);
        GUI.Box(new Rect(130,0,130,25), player1.name);
        GUI.Box(new Rect(260,0,130,25), player2.name);
        GUI.Box(new Rect(0, 25, 390, 25), "Деньги:");
        GUI.Box(new Rect(20, 50, 90, 25), "" + player0.money);
        GUI.Box(new Rect(150, 50, 90, 25), "" + player1.money);
        GUI.Box(new Rect(280, 50, 90, 25), "" + player2.money);
        if (GUI.Button(new Rect(0, 50, 20, 25), "-")) { player0.takemoney(); }
        if (GUI.Button(new Rect(130, 50, 20, 25), "-")) { player1.takemoney(); }
        if (GUI.Button(new Rect(260, 50, 20, 25), "-")) { player2.takemoney(); }
        if (GUI.Button(new Rect(110, 50, 20, 25), "+")) { player0.addmoney(); }
        if (GUI.Button(new Rect(240, 50, 20, 25), "+")) { player1.addmoney(); }
        if (GUI.Button(new Rect(370, 50, 20, 25), "+")) { player2.addmoney(); }
        GUI.Box(new Rect(0, 75, 390, 25), "Очки города:");
        GUI.Box(new Rect(20, 100, 90, 25), "" + player0.citypoints);
        GUI.Box(new Rect(150, 100, 90, 25), "" + player1.citypoints);
        GUI.Box(new Rect(280, 100, 90, 25), "" + player2.citypoints);
        if (GUI.Button(new Rect(0, 100, 20, 25), "-")) { player0.takecitypoints(); }
        if (GUI.Button(new Rect(130, 100, 20, 25), "-")) { player1.takecitypoints(); }
        if (GUI.Button(new Rect(260, 100, 20, 25), "-")) { player2.takecitypoints(); }
        if (GUI.Button(new Rect(110, 100, 20, 25), "+")) { player0.addcitypoints(); }
        if (GUI.Button(new Rect(240, 100, 20, 25), "+")) { player1.addcitypoints(); }
        if (GUI.Button(new Rect(370, 100, 20, 25), "+")) { player2.addcitypoints(); }
        if (GUI.Button(new Rect(0, 125, 130, 25), "Купить О. Гор")) { player0.buycitypoints(); }
        if (GUI.Button(new Rect(130, 125, 130, 25), "Купить О. Гор")) { player1.buycitypoints(); }
        if (GUI.Button(new Rect(260, 125, 130, 25), "Купить О. Гор")) { player2.buycitypoints(); }
        GUI.Box(new Rect(0, 150, 390, 25), "Очки армии:");
        GUI.Box(new Rect(20, 175, 90, 25), "" + player0.armypoints);
        GUI.Box(new Rect(150, 175, 90, 25), "" + player1.armypoints);
        GUI.Box(new Rect(280, 175, 90, 25), "" + player2.armypoints);
        if (GUI.Button(new Rect(0, 175, 20, 25), "-")) { player0.takearmypoints(); }
        if (GUI.Button(new Rect(130, 175, 20, 25), "-")) { player1.takearmypoints(); }
        if (GUI.Button(new Rect(260, 175, 20, 25), "-")) { player2.takearmypoints(); }
        if (GUI.Button(new Rect(110, 175, 20, 25), "+")) { player0.addarmypoints(); }
        if (GUI.Button(new Rect(240, 175, 20, 25), "+")) { player1.addarmypoints(); }
        if (GUI.Button(new Rect(370, 175, 20, 25), "+")) { player2.addarmypoints(); }
        if (GUI.Button(new Rect(0, 200, 130, 25), "Купить О. Арм")) { player0.buyarmypoints(); }
        if (GUI.Button(new Rect(130, 200, 130, 25), "Купить О. Арм")) { player1.buyarmypoints(); }
        if (GUI.Button(new Rect(260, 200, 130, 25), "Купить О. Арм")) { player2.buyarmypoints(); }
        GUI.Box(new Rect(0, 225, 390, 25), "Города:");
        GUI.Box(new Rect(20, 250, 90, 25), "" + player0.cityes);
        GUI.Box(new Rect(150, 250, 90, 25), "" + player1.cityes);
        GUI.Box(new Rect(280, 250, 90, 25), "" + player2.cityes);
        if (GUI.Button(new Rect(0, 250, 20, 25), "-")) { player0.takecityes(); }
        if (GUI.Button(new Rect(130, 250, 20, 25), "-")) { player1.takecityes(); }
        if (GUI.Button(new Rect(260, 250, 20, 25), "-")) { player2.takecityes(); }
        if (GUI.Button(new Rect(110, 250, 20, 25), "+")) { player0.addcityes(); }
        if (GUI.Button(new Rect(240, 250, 20, 25), "+")) { player1.addcityes(); }
        if (GUI.Button(new Rect(370, 250, 20, 25), "+")) { player2.addcityes(); }
        if (GUI.Button(new Rect(0, 275, 130, 25), "Купить город")) { player0.buycity(); }
        if (GUI.Button(new Rect(130, 275, 130, 25), "Купить город")) { player1.buycity(); }
        if (GUI.Button(new Rect(260, 275, 130, 25), "Купить город")) { player2.buycity(); }
        GUI.Box(new Rect(0, 300, 390, 25), "Порты:");
        GUI.Box(new Rect(20, 325, 90, 25), "" + player0.ports);
        GUI.Box(new Rect(150, 325, 90, 25), "" + player1.ports);
        GUI.Box(new Rect(280, 325, 90, 25), "" + player2.ports);
        if (GUI.Button(new Rect(0, 325, 20, 25), "-")) { player0.takeports(); }
        if (GUI.Button(new Rect(130, 325, 20, 25), "-")) { player1.takeports(); }
        if (GUI.Button(new Rect(260, 325, 20, 25), "-")) { player2.takeports(); }
        if (GUI.Button(new Rect(110, 325, 20, 25), "+")) { player0.addports(); }
        if (GUI.Button(new Rect(240, 325, 20, 25), "+")) { player1.addports(); }
        if (GUI.Button(new Rect(370, 325, 20, 25), "+")) { player2.addports(); }
        if (GUI.Button(new Rect(0, 350, 130, 25), "Купить порт")) { player0.buyport(); }
        if (GUI.Button(new Rect(130, 350, 130, 25), "Купить порт")) { player1.buyport(); }
        if (GUI.Button(new Rect(260, 350, 130, 25), "Купить порт")) { player2.buyport(); }
        GUI.Box(new Rect(0, 375, 390, 25), "Артефакты:");
        GUI.Box(new Rect(20, 400, 90, 25), "" + player0.artifacts);
        GUI.Box(new Rect(150, 400, 90, 25), "" + player1.artifacts);
        GUI.Box(new Rect(280, 400, 90, 25), "" + player2.artifacts);
        if (GUI.Button(new Rect(0, 400, 20, 25), "-")) { player0.takeartifacts(); }
        if (GUI.Button(new Rect(130, 400, 20, 25), "-")) { player1.takeartifacts(); }
        if (GUI.Button(new Rect(260, 400, 20, 25), "-")) { player2.takeartifacts(); }
        if (GUI.Button(new Rect(110, 400, 20, 25), "+")) { player0.addartifacts(); }
        if (GUI.Button(new Rect(240, 400, 20, 25), "+")) { player1.addartifacts(); }
        if (GUI.Button(new Rect(370, 400, 20, 25), "+")) { player2.addartifacts(); }
        if (GUI.Button(new Rect(0, 425, 130, 25), "Купить артефакт")) { player0.buyartifact(); }
        if (GUI.Button(new Rect(130, 425, 130, 25), "Купить артефакт")) { player1.buyartifact(); }
        if (GUI.Button(new Rect(260, 425, 130, 25), "Купить артефакт")) { player2.buyartifact(); }
        GUI.Box(new Rect(0, 450, 390, 25), "Гильдии:");
        GUI.Box(new Rect(20, 475, 90, 25), "" + player0.guilds);
        GUI.Box(new Rect(150, 475, 90, 25), "" + player1.guilds);
        GUI.Box(new Rect(280, 475, 90, 25), "" + player2.guilds);
        if (GUI.Button(new Rect(0, 475, 20, 25), "-")) { player0.takeguilds(); }
        if (GUI.Button(new Rect(130, 475, 20, 25), "-")) { player1.takeguilds(); }
        if (GUI.Button(new Rect(260, 475, 20, 25), "-")) { player2.takeguilds(); }
        if (GUI.Button(new Rect(110, 475, 20, 25), "+")) { player0.addguilds(); }
        if (GUI.Button(new Rect(240, 475, 20, 25), "+")) { player1.addguilds(); }
        if (GUI.Button(new Rect(370, 475, 20, 25), "+")) { player2.addguilds(); }
        if (GUI.Button(new Rect(0, 500, 130, 25), "Купить гильдию")) { player0.buyguild(); }
        if (GUI.Button(new Rect(130, 500, 130, 25), "Купить гильдию")) { player1.buyguild(); }
        if (GUI.Button(new Rect(260, 500, 130, 25), "Купить гильдию")) { player2.buyguild(); }
        GUI.Box(new Rect(0, 525, 390, 25), "Подполья:");
        GUI.Box(new Rect(20, 550, 90, 25), "" + player0.undergrounds);
        GUI.Box(new Rect(150, 550, 90, 25), "" + player1.undergrounds);
        GUI.Box(new Rect(280, 550, 90, 25), "" + player2.undergrounds);
        if (GUI.Button(new Rect(0, 550, 20, 25), "-")) { player0.takeunderground(); }
        if (GUI.Button(new Rect(130, 550, 20, 25), "-")) { player1.takeunderground(); }
        if (GUI.Button(new Rect(260, 550, 20, 25), "-")) { player2.takeunderground(); }
        if (GUI.Button(new Rect(110, 550, 20, 25), "+")) { player0.addunderground(); }
        if (GUI.Button(new Rect(240, 550, 20, 25), "+")) { player1.addunderground(); }
        if (GUI.Button(new Rect(370, 550, 20, 25), "+")) { player2.addunderground(); }
        if (GUI.Button(new Rect(0, 575, 130, 25), "Купить подполье")) { player0.buyunderground(); }
        if (GUI.Button(new Rect(130, 575, 130, 25), "Купить подполье")) { player1.buyunderground(); }
        if (GUI.Button(new Rect(260, 575, 130, 25), "Купить подполье")) { player2.buyunderground(); }
        if (GUI.Button(new Rect(0, 600, 390, 25), "Рассчитать доход")) { player0.calculatemoney(); player1.calculatemoney(); player2.calculatemoney(); }

        GUI.Box(new Rect(390, 0, 70, 25), "D20");
        GUI.Box(new Rect(390, 25, 50, 25), d20.ToString());
        if (GUI.Button(new Rect(440, 25, 20, 25), "r")) { d20 = Random.Range(0, 20)+1; }
    }
}
