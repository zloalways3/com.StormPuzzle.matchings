using UnityEngine;
using UnityEngine.Events;

public class Events_Trigger_StormPuzzle : MonoBehaviour
{
    [SerializeField] private UnityEvent onStart_StormPuzzle;
    [SerializeField] private UnityEvent onAwake_StormPuzzle;
    [SerializeField] private UnityEvent onEnable_StormPuzzle;
    [SerializeField] private UnityEvent onDisable_StormPuzzle;

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    private int randomInt1;
    private int randomInt2;
    private float randomFloat1;
    private float randomFloat2;
    private bool randomBool1;
    private bool randomBool2;
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    private void Awake()
    {
        onAwake_StormPuzzle?.Invoke();
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
    void Start()
    {
        onStart_StormPuzzle?.Invoke();
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

    private void OnEnable()
    {
        onEnable_StormPuzzle?.Invoke();
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

    private void OnDisable()
    {
        onDisable_StormPuzzle?.Invoke();
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
