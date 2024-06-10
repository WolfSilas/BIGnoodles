using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] private Vector3 openPosition;  // The position when the door is open
    [SerializeField] private Vector3 openRotation;  // The rotation when the door is open
    [SerializeField] private float transitionDuration = 1.0f;  // Duration of the transition
    public Quest nameQuest;       //
    public string questname;        //
    public string questdescription; //
    public QInteracion QuestInteraction;    //
    private Vector3 originalPosition;  
    private Quaternion originalRotation;  
    private bool isOpen = false;  
    private bool isTransitioning = false;
    public ShopManager shopManager;
    public string InteractionPrompt => _prompt;
    public int DoorCounter = 0;
    public int CompletePrice = 0;
    private void Start()
    {
        questdescription = nameQuest.description;
        questname = nameQuest.questName;
        originalPosition = transform.position;
        originalRotation = transform.rotation;

    }
    
    public bool Interact(Interactor interactor )
    {
        
        if ( DoorCounter == 0 )
        QuestInteraction.Interact(questname,questdescription);
        DoorCounter++;
        if (CompletePrice ==0)
        {
           // shopManager.AddTokens();
        }
        CompletePrice++;
        if (!isTransitioning)
        {
            if (isOpen)
            {
                // Move and rotate the door back to its original position and rotation
                StartCoroutine(MoveDoor(originalPosition, originalRotation));
                Debug.Log("Door closing");
            }
            else
            {
                // Move and rotate the door to the open position and rotation
                StartCoroutine(MoveDoor(openPosition, Quaternion.Euler(openRotation)));
                Debug.Log("Door opening");
            }

            // Toggle the state of the door
            isOpen = !isOpen;
        }

        return true;
    }

    private IEnumerator MoveDoor(Vector3 targetPosition, Quaternion targetRotation)
    {
        isTransitioning = true;

        Vector3 startPosition = transform.position;
        Quaternion startRotation = transform.rotation;

        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / transitionDuration);
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsedTime / transitionDuration);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the door is exactly at the target position and rotation after the transition
        transform.position = targetPosition;
        transform.rotation = targetRotation;

        isTransitioning = false;

    }
}


