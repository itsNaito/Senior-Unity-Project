using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum battleState {start, playerTurn, enemyTurn,won,lost};
public class battleStates : MonoBehaviour
{
    public Text text;
    public battleState state;
    public GameObject player;
    public GameObject enemy;
    public Transform playerSpawn;
    public Transform enemySpawn;
    characterStats playerStats;
    characterStats enemyStats;
    bool enemyIsDead;
    bool playerIsDead;
    private GameObject zombieInit;
    private GameObject playerInit;
    // Start is called before the first frame update
    void Start()
    {
        state = battleState.start;
        StartCoroutine(initBattle());
    }
    IEnumerator initBattle()
    {
        playerInit = Instantiate(player,playerSpawn);
        playerInit.SetActive(true);
        playerStats = playerInit.GetComponent<characterStats>();
        zombieInit = Instantiate(enemy,enemySpawn);
        zombieInit.SetActive(true);
        enemyStats = zombieInit.GetComponent<characterStats>();
        text.text = "A " + enemyStats.unitName + " approaches....";

        yield return new WaitForSeconds(2f);

        state = battleState.playerTurn;
        playerTurn();
    }
    IEnumerator playerAttack()
    {
        yield return new WaitForSeconds(1f);
        enemyIsDead = enemyStats.takeDamage(playerStats.damage);
        text.text = "You used a "+ playerStats.attack + " that dealt " + playerStats.damage + " to the zombie";
        yield return new WaitForSeconds(1.5f);
        if(enemyIsDead)
        {
            state = battleState.won;
            zombieInit.SetActive(false);
            endBattle();
        }
        else
        {
            state = battleState.enemyTurn;
            StartCoroutine(enemyAttack());
        }
    }
    IEnumerator enemyAttack()
    {
        yield return new WaitForSeconds(1.5f);
        text.text = "The zombie is attacking";
        yield return new WaitForSeconds(1.5f);
        playerIsDead = playerStats.takeDamage(enemyStats.damage);
        text.text = "The zombie used " + enemyStats.attack + " that dealt " + enemyStats.damage + " to you";
        yield return new WaitForSeconds(1.5f);
        if(playerIsDead)
        {
            state = battleState.lost;
            playerInit.SetActive(false);
            endBattle();
        }
        else
        {
            state = battleState.playerTurn;
            text.text = "Player's turn";
        }
    }
    void endBattle()
    {
        if(state == battleState.won)
        {
            text.text = "You have won the battle!!";
        }
        else if(state == battleState.lost)
        {
            text.text = "You have lost the battle!!";
        }
    }
    void playerTurn()
    {
        text.text = "Player's Turn. Choose an action";
    }
    public void onAttackButton()
    {
        if(state != battleState.playerTurn)
        {
            return;
        }
        StartCoroutine(playerAttack());
    }
}
