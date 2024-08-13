using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using System;
using Coffee.UIExtensions;
using UnityEngine.Events;

public class VisualControl_States_StormPuzzle : MonoBehaviour
{
    [SerializeField] private VisualStatesUI_StormPuzzle[] uiSatatesToControl_StormPuzzle;
    [SerializeField] private UnityEvent onChangeState_StormPuzzle, onOn_StormPuzzle, onOff_StormPuzzle;

    [SerializeField] private bool _isActive_StormPuzzle = false;
    public bool isActive_StormPuzzle
    {
        set
        {
            _isActive_StormPuzzle = value;
            UpdateStateUI_StormPuzzle();
            onChangeState_StormPuzzle?.Invoke();
            if (value)
            {
                onOn_StormPuzzle?.Invoke();
            }
            else
            {
                onOff_StormPuzzle?.Invoke();
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
        get { return _isActive_StormPuzzle; }
    }


    private Tween animColor_Text_StormPuzzle;
    private Tween animColor_Image_StormPuzzle;


    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    private int randomInt1;
    private int randomInt2;
    private float randomFloat1;
    private float randomFloat2;
    private bool randomBool1;
    private bool randomBool2;
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<







    private void UpdateStateUI_StormPuzzle()
    {

        if (animColor_Text_StormPuzzle != null)
            animColor_Text_StormPuzzle.Kill();

        if (animColor_Image_StormPuzzle != null)
            animColor_Image_StormPuzzle.Kill();


        foreach (var uiAccess in uiSatatesToControl_StormPuzzle)
        {
            if (_isActive_StormPuzzle)
            {
                if (uiAccess._text_StormPuzzle != null)
                    animColor_Text_StormPuzzle = DOTween.To(() => uiAccess._text_StormPuzzle.color, x => uiAccess._text_StormPuzzle.color = x, uiAccess.color_Enable_StormPuzzle, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_ChangeColor_StormPuzzle != null)
                    animColor_Image_StormPuzzle = DOTween.To(() => uiAccess._image_ChangeColor_StormPuzzle.effectColor, x => uiAccess._image_ChangeColor_StormPuzzle.effectColor = x, uiAccess.color_Enable_StormPuzzle, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_StormPuzzle != null)
                    uiAccess._image_StormPuzzle.sprite = uiAccess.sprite_Enable_StormPuzzle;

            }
            else
            {
                if (uiAccess._text_StormPuzzle != null)
                    animColor_Text_StormPuzzle = DOTween.To(() => uiAccess._text_StormPuzzle.color, x => uiAccess._text_StormPuzzle.color = x, uiAccess.color_Disable_StormPuzzle, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_ChangeColor_StormPuzzle != null)
                    animColor_Image_StormPuzzle = DOTween.To(() => uiAccess._image_ChangeColor_StormPuzzle.effectColor, x => uiAccess._image_ChangeColor_StormPuzzle.effectColor = x, uiAccess.color_Disable_StormPuzzle, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_StormPuzzle != null)
                    uiAccess._image_StormPuzzle.sprite = uiAccess.sprite_Disable_StormPuzzle;
            }
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

    public void SetState_StormPuzzle(bool state)
    {
        _isActive_StormPuzzle = state;
        UpdateStateUI_StormPuzzle();


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

    [ContextMenu("Toggle")]
    private void ToggleState_StormPuzzle()
    {
        isActive_StormPuzzle = !isActive_StormPuzzle;

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

[Serializable]
public class VisualStatesUI_StormPuzzle
{
    public TMP_Text _text_StormPuzzle;
    public Color color_Enable_StormPuzzle, color_Disable_StormPuzzle;
    public UIEffect _image_ChangeColor_StormPuzzle;
    public Image _image_StormPuzzle;
    public Sprite sprite_Enable_StormPuzzle, sprite_Disable_StormPuzzle;

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    private int randomInt1;
    private int randomInt2;
    private float randomFloat1;
    private float randomFloat2;
    private bool randomBool1;
    private bool randomBool2;
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
}
