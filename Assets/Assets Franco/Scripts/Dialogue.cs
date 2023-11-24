using System.Collections;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private GameObject PuntoDialogo, CapsulaDialogo;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(6, 6)]private string[] dialogueLines;

    private float typingTime = 0.05f;
    private bool isPlayerInRange;
    private bool didDialogueStart;
    private int lineIndex;
    public float interactionDistance = 2f;
    public LayerMask interactionLayer;

    public void Interaction(){
        if(!didDialogueStart){
            StartDialogue();
        }
        else if(dialogueText.text == dialogueLines[lineIndex]){
            NextDialogueLine();
        }       
        else{
            StopAllCoroutines();
            dialogueText.text = dialogueLines[lineIndex];
        }
    }

    private void StartDialogue(){
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        PuntoDialogo.SetActive(false);
        CapsulaDialogo.SetActive(false);
        lineIndex = 0;
        Time.timeScale = 0f;
        StartCoroutine(ShowLine());
    }

    private void NextDialogueLine(){
        lineIndex++;
        if(lineIndex < dialogueLines.Length){
            StartCoroutine(ShowLine());
        }
        else{
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            PuntoDialogo.SetActive(true);
            CapsulaDialogo.SetActive(true);
            Time.timeScale = 1f;
        }
    }
    private IEnumerator ShowLine(){
        dialogueText.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex]){
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typingTime); 
        }
    }
}