using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class DialogManagerUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject dialogPanel;
    [SerializeField] private TMP_Text dialogTitle_text;
    [SerializeField] private TMP_Text dialogDescription_text;

    [Header("Settings")]
    [SerializeField] private float letterPerSecond = 0.065f;
    [SerializeField] private float delayAfterDialog = 2f;

    [Header("Events")]
    public UnityEvent onDialogStarted;
    public UnityEvent onDialogEnded;

    private bool _isWritingDialog = false;


    private void Start()
    {
        dialogPanel.SetActive(false);
    }


    public void ShowDialog(Dialogue dialogue)
    {
        if (_isWritingDialog)
        {
            Debug.LogWarning("Can't show dialog while writing dialog!");
            return;
        }
        StartCoroutine(WriteDialog(dialogue));
    }

    private IEnumerator WriteDialog(Dialogue dialogue)
    {
        _isWritingDialog = true;
        dialogPanel.SetActive(true);
        onDialogStarted.Invoke();

        dialogTitle_text.text = "";
        dialogDescription_text.text = "";

        for (int i = 0; i < dialogue.title.Length; i++)
        {
            dialogTitle_text.text += dialogue.title[i];
            yield return new WaitForSeconds(letterPerSecond);
        }

        for (int i = 0; i < dialogue.description.Length; i++)
        {
            dialogDescription_text.text += dialogue.description[i];
            yield return new WaitForSeconds(letterPerSecond);
        }

        yield return new WaitForSeconds(delayAfterDialog);
        dialogPanel.SetActive(false);

        onDialogEnded.Invoke();

        _isWritingDialog = false;
    }
}
