using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public enum GameState {START, GAME, ENDGAME}

    public GameState gameState { get; private set; }

    public int score;

    public delegate void ChangeStateDelegate();
    public static ChangeStateDelegate changeStateDelegate;

    private static GameManager _instance;

    private GameManager()
    {
        score = 0;
        gameState = GameState.START;

    }
    public static GameManager GetInstance()
    {
        if(_instance == null)
        {
            _instance = new GameManager();
        }

        return _instance;
    }

    public void ChangeState(GameState nextState)
    {
        if (nextState == GameState.GAME) Reset();

        gameState = nextState;
        changeStateDelegate();
    }

    private void Reset() {
        score = 0;
    }
}
