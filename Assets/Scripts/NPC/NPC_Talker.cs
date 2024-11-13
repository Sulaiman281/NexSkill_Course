using System;
using UnityEngine;

public class NPC_Talker : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform target;
    [SerializeField] private DialogManagerUI dialogManagerUI;

    [Header("Settings")]
    [SerializeField] private TalkerState state;

    [Header("Dialogues")]
    [SerializeField] private Dialogue[] dialogues;

    private int currentDialogueIndex = 0;

    // properties
    public Transform Target { get => target; set => target = value; }

    private void Start()
    {
        currentDialogueIndex = 0;
        SetState(TalkerState.Idle);
    }

    public void Update()
    {
        switch (state)
        {
            case TalkerState.Idle:
                UpdateIdle();
                break;
            case TalkerState.Talking:
                UpdateTalking();
                break;
            case TalkerState.Listening:
                UpdateListening();
                break;
            default:
                break;
        }
    }

    private void UpdateIdle()
    {
        // Do nothing
    }

    private void UpdateTalking()
    {
        // Do nothing
    }

    private void UpdateListening()
    {
        // Do nothing
    }


    public void SetState(TalkerState newState)
    {
        // previous state changes
        switch (state)
        {
            case TalkerState.Idle:
                break;
            case TalkerState.Talking:
                break;
            case TalkerState.Listening:
                break;
            default:
                break;
        }

        state = newState;

        // new state changes
        switch (state)
        {
            case TalkerState.Idle:
                // on new idle state enter
                break;
            case TalkerState.Talking:
                break;
            case TalkerState.Listening:
                break;
            default:
                break;
        }
    }


    public void StartTalking()
    {
        SetState(TalkerState.Talking);
        PlayDialog();
    }


    private void PlayDialog()
    {
        if (currentDialogueIndex < 0 || currentDialogueIndex >= dialogues.Length)
        {
            Debug.LogError("Invalid dialogue index!");
            return;
        }


        // play dialog
        dialogManagerUI.ShowDialog(dialogues[currentDialogueIndex]);

    }

    public void PlayDialogIndex(int index)
    {
        currentDialogueIndex = index;
        PlayDialog();
    }

    public void ResetState()
    {
        currentDialogueIndex = 0;
        SetState(TalkerState.Idle);
    }
}

public enum TalkerState
{
    Idle = 0,
    Talking = 1,
    Listening = 2
}


[Serializable] // to make it visible in the inspector
public struct Dialogue
{
    public string title;
    public string description;
    public AudioClip voiceOver;

}
