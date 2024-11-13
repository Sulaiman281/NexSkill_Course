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
    [SerializeField] private AudioSource globalAudioSource;

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

        PlayVoice(dialogue.voiceOver);

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

        float totalTextDuration = (dialogue.title.Length + dialogue.description.Length) * letterPerSecond;

        if(dialogue.voiceOver != null)
        {
            float remainingDuration = dialogue.voiceOver.length - totalTextDuration;
       
            if(remainingDuration >= 0)
            {
                yield return new WaitForSeconds(remainingDuration);
            }
        }


        yield return new WaitForSeconds(delayAfterDialog);

        _isWritingDialog = false;
        dialogPanel.SetActive(false);
        onDialogEnded.Invoke();
    }

    private void PlayVoice(AudioClip voiceOver)
    {
        if(voiceOver == null)
        {
            return;
        }

        globalAudioSource.clip = voiceOver;
        globalAudioSource.Play();
    }
}
