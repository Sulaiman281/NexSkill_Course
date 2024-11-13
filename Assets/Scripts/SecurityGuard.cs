using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityGuard : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private NPC_Talker npcTalker;

    [Header("Settings")]
    [SerializeField] private int ticketConfirmIndex = 1;
    [SerializeField] private int ticketDenyIndex = 2;



    public void CheckTicket()
    {
        if (npcTalker == null)
        {
            Debug.LogError("NPC Talker is not assigned!");
            return;
        }

        if(ConcertManager.Instance.Inventory.hasTicket)
        {
            npcTalker.PlayDialogIndex(ticketConfirmIndex);
            //TODO: open the gate.
        }
        else
        {
            npcTalker.PlayDialogIndex(ticketDenyIndex);
        }
    }
}
