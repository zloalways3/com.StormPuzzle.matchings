using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class AnimationBehaviour_StormPuzzle : MonoBehaviour
{

    //[FormerlySerializedAs("gameObjectToMove_UrbanEnigma")]
    public GameObject gameObjectToMove_StormPuzzle;
    //[FormerlySerializedAs("targetPosition_UrbanEnigma")]
    public Transform targetPosition_StormPuzzle;
    //[FormerlySerializedAs("moveSpeed_UrbanEnigma")]
    public float moveSpeed_StormPuzzle = 1f;
    //[FormerlySerializedAs("easeType_UrbanEnigma")]
    public Ease easeType_StormPuzzle = Ease.Linear;
    //[FormerlySerializedAs("moveOnXAxis_UrbanEnigma")]
    public bool moveOnXAxis_StormPuzzle = true;
    //[FormerlySerializedAs("moveOnYAxis_UrbanEnigma")]
    public bool moveOnYAxis_StormPuzzle = true;
    //[FormerlySerializedAs("gameObjectToMove2_UrbanEnigma")]
    public GameObject gameObjectToMove2_StormPuzzle;
    //[FormerlySerializedAs("targetPosition2_UrbanEnigma")]
    public Transform targetPosition2_StormPuzzle;
    //[FormerlySerializedAs("on_first_object_start_UrbanEnigma")]
    public UnityEvent on_first_object_start_StormPuzzle;
    //[FormerlySerializedAs("on_first_object_finish_UrbanEnigma")]
    public UnityEvent on_first_object_finish_StormPuzzle;
    //[FormerlySerializedAs("on_second_object_start_UrbanEnigma")]
    public UnityEvent on_second_object_start_StormPuzzle;
    //[FormerlySerializedAs("on_second_object_finish_UrbanEnigma")]
    public UnityEvent on_second_object_finish_StormPuzzle;


    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    private int randomInt1;
    private int randomInt2;
    private float randomFloat1;
    private float randomFloat2;
    private bool randomBool1;
    private bool randomBool2;
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    public void MoveObjectToTarget()
    {
        if (gameObjectToMove_StormPuzzle != null && targetPosition_StormPuzzle != null)
        {
            on_first_object_start_StormPuzzle?.Invoke();

            Vector3 targetPos = new Vector3(moveOnXAxis_StormPuzzle ? targetPosition_StormPuzzle.position.x : gameObjectToMove_StormPuzzle.transform.position.x,
                moveOnYAxis_StormPuzzle ? targetPosition_StormPuzzle.position.y : gameObjectToMove_StormPuzzle.transform.position.y,
                gameObjectToMove_StormPuzzle.transform.position.z);

            gameObjectToMove_StormPuzzle.transform.DOMove(targetPos, moveSpeed_StormPuzzle).SetEase(easeType_StormPuzzle).OnComplete(() =>
            {
                on_first_object_finish_StormPuzzle?.Invoke();
            });
        }


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool runRandomlogic = false;
        if (runRandomlogic)
        {
            // Modify the value of myVariable
            int myVariable = 5;
            Debug.Log("MyVariable value: " + myVariable);
            GameObject targetObject = new GameObject();
            // Move the game object towards a target
            if (targetObject != null)
            {
                transform.position = Vector3.Lerp(transform.position, targetObject.transform.position, myVariable * Time.deltaTime);
            }

            // Check if the game object has reached the target
            if (Vector3.Distance(transform.position, targetObject.transform.position) < 0.1f)
            {
                Debug.Log("Reached the target!");
            }

            // Invoke the method again after a short delay
            Invoke("DoSomething", 2.0f);
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public void MoveObjectToTarget2()
    {
        if (gameObjectToMove2_StormPuzzle != null && targetPosition2_StormPuzzle != null)
        {
            on_second_object_start_StormPuzzle?.Invoke();

            Vector3 targetPos2 = new Vector3(moveOnXAxis_StormPuzzle ? targetPosition2_StormPuzzle.position.x : gameObjectToMove2_StormPuzzle.transform.position.x,
                moveOnYAxis_StormPuzzle ? targetPosition2_StormPuzzle.position.y : gameObjectToMove2_StormPuzzle.transform.position.y,
                gameObjectToMove2_StormPuzzle.transform.position.z);

            gameObjectToMove2_StormPuzzle.transform.DOMove(targetPos2, moveSpeed_StormPuzzle).SetEase(easeType_StormPuzzle).OnComplete(() =>
            {
                on_second_object_finish_StormPuzzle?.Invoke();
            });
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool runRandomlogic = false;
        if (runRandomlogic)
        {
            // Modify the value of myVariable
            int myVariable = 5;
            Debug.Log("MyVariable value: " + myVariable);
            GameObject targetObject = new GameObject();
            // Move the game object towards a target
            if (targetObject != null)
            {
                transform.position = Vector3.Lerp(transform.position, targetObject.transform.position, myVariable * Time.deltaTime);
            }

            // Check if the game object has reached the target
            if (Vector3.Distance(transform.position, targetObject.transform.position) < 0.1f)
            {
                Debug.Log("Reached the target!");
            }

            // Invoke the method again after a short delay
            Invoke("DoSomething", 2.0f);
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }


    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    public void PlaceObjectRandomly(GameObject obj, float minX, float maxX, float minZ, float maxZ)
    {
        // Generate random position within the specified bounds
        float randomX = UnityEngine.Random.Range(minX, maxX);
        float randomZ = UnityEngine.Random.Range(minZ, maxZ);
        Vector3 randomPosition = new Vector3(randomX, obj.transform.position.y, randomZ);

        // Set the object's position to the random position
        obj.transform.position = randomPosition;
    }
    public void RotateObjectRandomly(GameObject obj, float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
    {
        // Generate random rotation values within the specified ranges
        float randomX = UnityEngine.Random.Range(minX, maxX);
        float randomY = UnityEngine.Random.Range(minY, maxY);
        float randomZ = UnityEngine.Random.Range(minZ, maxZ);
        Quaternion randomRotation = Quaternion.Euler(randomX, randomY, randomZ);

        // Set the object's rotation to the random rotation
        obj.transform.rotation = randomRotation;
    }

    public void ScaleObjectRandomly(GameObject obj, float minScale, float maxScale)
    {
        // Generate random scale value within the specified range
        float randomScale = UnityEngine.Random.Range(minScale, maxScale);

        // Set the object's scale to the random scale
        obj.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
    }

    public void ChangeColorRandomly(GameObject obj)
    {
        // Generate random color values
        float randomR = UnityEngine.Random.Range(0f, 1f);
        float randomG = UnityEngine.Random.Range(0f, 1f);
        float randomB = UnityEngine.Random.Range(0f, 1f);
        Color randomColor = new Color(randomR, randomG, randomB);

        // Set the object's color to the random color
        obj.GetComponent<Renderer>().material.color = randomColor;
    }

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
}
