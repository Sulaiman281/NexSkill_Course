using UnityEngine;
using System;
public class ConcertManager : MonoBehaviour
{
    private static ConcertManager instance;

    public static ConcertManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ConcertManager>();
            }
            return instance;
        }
    }

    [Header("Data")]
    [SerializeField] private PlayerInventory playerInventory;


    [Header("References")]
    [SerializeField] private DialogManagerUI dialogManagerUI;
    [SerializeField] private SecurityGuard securityCheckPost;

// this method is public so that can be called from other scripts and only can read it. 
    public PlayerInventory Inventory => playerInventory;

    public DialogManagerUI DialogManagerUI 
    {
        get {
            if(dialogManagerUI == null)
            {
                dialogManagerUI = FindObjectOfType<DialogManagerUI>();
            }

            return dialogManagerUI;
        }
    }

    public SecurityGuard CheckPost
    {
        get
        {
            if (securityCheckPost == null)
            {
                securityCheckPost = FindObjectOfType<SecurityGuard>();
            }

            return securityCheckPost;
        }
    }

    private NPC_Talker currentNPCTalker; // here we store npc which is currently interacting with player.

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        PlayerInventory inv = Inventory;
        inv.hasTicket = false;
        inv.coins = 0;

        playerInventory = inv;
    }

    public void SetCurrentNPCTalker(Transform target)
    {
        if(target.TryGetComponent(out NPC_Talker talker))
        {
            currentNPCTalker = talker;
        }

        // on dialog eng
        DialogManagerUI.onDialogEnded.AddListener(SecurityPostLogic);

    }

    private void SecurityPostLogic()
    {
        CheckPost.CheckTicket();
        DialogManagerUI.onDialogEnded.RemoveListener(SecurityPostLogic);
    }
}

[Serializable]
public struct PlayerInventory
{
    public bool hasTicket;
    public float coins;
}
