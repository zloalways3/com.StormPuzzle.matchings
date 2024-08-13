using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.Serialization;

public class Manager_Game_StormPuzzle : MonoBehaviour
{
    //[FormerlySerializedAs("onGameStart_UrbanEnigma")]
    public UnityEvent onGameStart_StormPuzzle;
    //[FormerlySerializedAs("onGameFinish_UrbanEnigma")]
    public UnityEvent onGameFinish_StormPuzzle;
    //[FormerlySerializedAs("onNextClick_UrbanEnigma")]
    public UnityEvent onNextClick_StormPuzzle;
    //[FormerlySerializedAs("levels_data_UrbanEnigma")]
    public LevelsData_StormPuzzle levels_data_StormPuzzle;
    //[FormerlySerializedAs("movesText_UrbanEnigma")]
    public TMP_Text title_level;
    public TMP_Text text_level_completed;


    private Level_StormPuzzle current_level_data_StormPuzzle;
    private int current_level_StormPuzzle;
    private AllLevelsData_StormPuzzle all_levels_data_StormPuzzle = new AllLevelsData_StormPuzzle();
    private bool game_running_StormPuzzle = false;




    public static Manager_Game_StormPuzzle instance;


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
        instance = this;

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


    public void StartLevel_StormPuzzle(int level)
    {

        onGameStart_StormPuzzle?.Invoke();

        current_level_data_StormPuzzle = GetLevel_StormPuzzle(level);
        current_level_StormPuzzle = level;
        title_level.text = $"Level: {level}";

        if (current_level_data_StormPuzzle == null)
            return;

        for (int i = 0; i < current_level_data_StormPuzzle.spritesLevel_StormPuzzle.Length; i++)
        {
            CellGame_StormPuzzle.on_set_icon_StormPuzzle?.Invoke(current_level_data_StormPuzzle.spritesLevel_StormPuzzle[i], i + 1);
        }

        CellGame_StormPuzzle.show_icon_StormPuzzle?.Invoke(true);

        DelayStartGame_StormPuzzle();


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

    private Level_StormPuzzle GetLevel_StormPuzzle(int level)
    {
        foreach (var item in levels_data_StormPuzzle.levels_StormPuzzle)
        {
            if (item.level_StormPuzzle == level)
                return item;
        }

        return null;


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


    private async void DelayStartGame_StormPuzzle()
    {
        await Task.Delay(TimeSpan.FromSeconds(3));

        game_running_StormPuzzle = true;
        CellGame_StormPuzzle.show_icon_StormPuzzle?.Invoke(false);


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













    private CellGame_StormPuzzle first_card_StormPuzzle, second_card_StormPuzzle;
    private bool is_firstCard_StormPuzzle = false;
    private bool lock_interaction_StormPuzzle = false;

    public void CardClicked_StormPuzzle(CellGame_StormPuzzle cell)
    {
        if (lock_interaction_StormPuzzle || cell.is_showing_icon_StormPuzzle || !game_running_StormPuzzle) return;
        lock_interaction_StormPuzzle = true;

        cell.Show_Icon_StormPuzzle(true);

        if (!is_firstCard_StormPuzzle)
        {
            is_firstCard_StormPuzzle = true;
            first_card_StormPuzzle = cell;
            lock_interaction_StormPuzzle = false;


        }
        else
        {
            second_card_StormPuzzle = cell;
            CheckCards_StormPuzzle();

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

    private async void CheckCards_StormPuzzle()
    {


        if (first_card_StormPuzzle.icon_for_cell_UrbanEnigma.ToString() == second_card_StormPuzzle.icon_for_cell_UrbanEnigma.ToString())
        {
            is_firstCard_StormPuzzle = false;
        }
        else
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            first_card_StormPuzzle.Show_Icon_StormPuzzle(false);
            second_card_StormPuzzle.Show_Icon_StormPuzzle(false);
            is_firstCard_StormPuzzle = false;
        }

        lock_interaction_StormPuzzle = false;
        CheckIfGameFinishes_StormPuzzle();


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

    private async void CheckIfGameFinishes_StormPuzzle()
    {
        bool all_cards_found = true;

        CellGame_StormPuzzle.isNotFound?.Invoke(() => { all_cards_found = false; });
        // foreach (var item in cells__UrbanEnigma)
        // {
        //     if (!item.is_showing_icon_UrbanEnigma)
        //         all_cards_found = false;
        // }

        if (all_cards_found)
        {
            onGameFinish_StormPuzzle?.Invoke();
            text_level_completed.text = $"Level Completed {current_level_StormPuzzle}";
            Debug.Log("Game Finished");
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

    private void LevelFinish_StormPuzzle()
    {
        CheckLevelUnlocked();
        FetchDataLevels_StormPuzzle();


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
    public void NextClick_StormPuzzle()
    {
        if (current_level_StormPuzzle < 12)
        {
            current_level_StormPuzzle++;
        }
        else
        {
            current_level_StormPuzzle = 1;

        }
        StartLevel_StormPuzzle(current_level_StormPuzzle);

        onNextClick_StormPuzzle?.Invoke();
        // LevelFinish_UrbanEnigma();


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



    private void SaveDataLevels()
    {
        var allData = new JSONObject("[]");



        var JsonObj_Data = new JSONObject(JsonUtility.ToJson(all_levels_data_StormPuzzle));
        allData.AddField("Levels", JsonObj_Data);

        PlayerPrefs.SetString("LevelsData", allData.ToString());


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

    private void LoadLevelsSaved()
    {
        if (PlayerPrefs.HasKey("LevelsData"))
        {
            var data_loaded = PlayerPrefs.GetString("LevelsData");
            var allData = new JSONObject(data_loaded);


            if (allData.HasField("Levels"))
            {
                all_levels_data_StormPuzzle = JsonUtility.FromJson<AllLevelsData_StormPuzzle>(allData["Levels"].ToString());
            }


            if (all_levels_data_StormPuzzle.levels_StormPuzzle.Count == 0)
            {
                LevelData_StormPuzzle level_d = new LevelData_StormPuzzle();
                level_d.level = 1;

                all_levels_data_StormPuzzle.levels_StormPuzzle.Add(level_d);
            }

            CheckLevelUnlocked();
            FetchDataLevels_StormPuzzle();
        }
        else
        {
            LevelData_StormPuzzle level_d = new LevelData_StormPuzzle();
            level_d.level = 1;

            all_levels_data_StormPuzzle.levels_StormPuzzle.Add(level_d);

            CheckLevelUnlocked();
            FetchDataLevels_StormPuzzle();
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

    private void CheckLevelUnlocked()
    {
        if (all_levels_data_StormPuzzle.levels_StormPuzzle.Count == 12) return;

        bool unlock_next = false;



        if (unlock_next)
        {
            LevelData_StormPuzzle level_n = new LevelData_StormPuzzle();
            level_n.level = all_levels_data_StormPuzzle.levels_StormPuzzle[all_levels_data_StormPuzzle.levels_StormPuzzle.Count - 1].level + 1;


            all_levels_data_StormPuzzle.levels_StormPuzzle.Add(level_n);
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

    private void FetchDataLevels_StormPuzzle()
    {
        // foreach (var item in all_levels_data.levels)
        // {
        //     Cell_UrbanEnigma.set_level?.Invoke(item);
        // }
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

    public void PlayTheHighestLevel_StormPuzzle()
    {
        StartLevel_StormPuzzle(all_levels_data_StormPuzzle.levels_StormPuzzle[all_levels_data_StormPuzzle.levels_StormPuzzle.Count - 1].level);


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
    public Vector3 GetRandomPosition(float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
    {
        float randomX = UnityEngine.Random.Range(minX, maxX);
        float randomY = UnityEngine.Random.Range(minY, maxY);
        float randomZ = UnityEngine.Random.Range(minZ, maxZ);
        return new Vector3(randomX, randomY, randomZ);
    }

    public Quaternion GetRandomRotation()
    {
        float randomX = UnityEngine.Random.Range(0f, 360f);
        float randomY = UnityEngine.Random.Range(0f, 360f);
        float randomZ = UnityEngine.Random.Range(0f, 360f);
        return Quaternion.Euler(randomX, randomY, randomZ);
    }

    public Color GetRandomColor()
    {
        float randomR = UnityEngine.Random.Range(0f, 1f);
        float randomG = UnityEngine.Random.Range(0f, 1f);
        float randomB = UnityEngine.Random.Range(0f, 1f);
        return new Color(randomR, randomG, randomB);
    }
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<



}

[Serializable]
public class AllLevelsData_StormPuzzle
{
    public List<LevelData_StormPuzzle> levels_StormPuzzle = new List<LevelData_StormPuzzle>();

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    private int randomInt1;
    private int randomInt2;
    private float randomFloat1;
    private float randomFloat2;
    private bool randomBool1;
    private bool randomBool2;
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
}


