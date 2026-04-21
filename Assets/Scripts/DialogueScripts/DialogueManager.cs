using UnityEngine;
using TMPro;
using System.Collections;
using DG.Tweening;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;
    public GameObject TextPanel;
    public TextMeshProUGUI DialogueText;
    public string[] CurrentLines;
    public float TextSpeed;
    public float PuncuationPause;
    public GameObject EnterText;
    public TMP_Text enterText;
    public bool IsTyping = false;
    

    public int index;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        DialogueText.text = string.Empty;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            if (IsTyping)
                return;
            else
            {
                enterText.DOFade(0, 2f);
                EnterText.SetActive(false);
                NextLine();
            }
                
            


            /*if (DialogueText.text == CurrentLines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                DialogueText.text = string.Empty;
                DialogueText.text = "";
                //TextPanel.SetActive(false);
            }*/
        }






    }

    public void StartDialogue(Dialogue dialogue)
    {
        //TextPanel.SetActive(true);
        index = 0;
        CurrentLines = dialogue.Lines;
        //index = 0;
        //IsTyping = true;
        StartCoroutine(TypeLine());
    }

    public IEnumerator TypeLine()
    {
        
        foreach (char c in CurrentLines[index].ToCharArray())
        {
            IsTyping = true;
            DialogueText.text += c;

            if (c == '.' || c == '!' || c == '?' || c == ',')
                yield return new WaitForSeconds(PuncuationPause);
            else
                yield return new WaitForSeconds(TextSpeed);

           
        }
        
        EnterText.SetActive(true);
        enterText.DOFade(160f, 2f);
        
        IsTyping = false;
    }

    public void NextLine()
    {
        if (index < CurrentLines.Length - 1)
        {
            index++;
            DialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            StopAllCoroutines();
            IsTyping = false;
            DialogueText.text = string.Empty;
            DialogueText.text = "";
            TextPanel.SetActive(false);
            
        }
    }
}
