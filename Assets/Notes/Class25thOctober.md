# Enhance Your Unity C# Programming Knowledge By Using Unity Builtin Tools.

## Topics We will Cover.
- How to Spawn GameObject or Prefabs In Running Game.
- How to Fetch Specific Components from a reference game object variable.
- How to Find Specific Components From a One or a list of components using unity c# builtin methods.
- We will also cover a IEnumerator. as an extra so you can create more about canvas.

we will understand best use case. where to use and where not to use. the following Topics


## Instantiate
- Instantiate is a builtin function or we say method in unity c# which use used to spawn or create GameObjects in our Running Game. 
```c#
public class GameManager : MonoBehavior
{
    public GameObject obstaclePrefab;
    public Transform obstacleParent;

    public void SpawnObstacle()
    {
        // in Instantiate method we can pass 1 or 2 or 3 parameters 
        // first parameter will be the object or prefab you want to spawn. in our case we want to spawn our obstaclePrefab so we will pass this reference variable of our prefab into our first parameter
        // 2nd we can pass either a transform reference or we can pass a Vector3 Position and if we pass the Vector3 position and in the third parameter we will pass a Quaternion for rotation.

        // first example just spawning a prefab

        Instantiate(obstaclePrefab); // this will create an obstacle in our 3d word space base on the default obstacle transform position. it should be always set to (0,0,0) so make sure to check your prefab if you don't see your object spawn at the correct position you want to spawn.

        Instantiate(obstaclePrefab, obstacleParent); // this will spawn our game object as a child of our obstacle parent reference and again our position will be depend on our prefab default parameters. but in locally means our game object (0,0,0) position will start base on parent object.

        Instantiate(obstaclePrefab, new Vector3(0, 0, 0), Quaternion.identity); // our game object will spawn at our given position and rotation and as you can see we have given (0,0,0) position and Quaternion.identity means the rotation also (0,0,0) and you can give your own position. and rotation will be Quaternion.Euler(0,0,0) instead of 0 you can give you position and make sure our vector parameter sequence follows like this (x,y,z) 

        // in above example we don't hold any reference of the object we spawn. what we are doing is we are spawning the object and forgetting it. when we want to apply more logic in our gameObject we need to store it in a variable to apply some changes.

        // like this
        GameObject obstacle = Instantiate(obstaclePrefab); // here we stored it reference in a variable. what we call our variable? obstacle

        // now we can apply our logic on our game object 

        obstacle.transform.SetParent(obstacleParent); // this way we can set parent of our object. SetParent() is the method of transform component. as we know transform component is by default included in every Game Object. and if you notice I have given GameObject in the start then i have given variable name and then i am assign it ( = ) with our Instantiate unity monobehavior buitin method which return our prefab reference which we are storing above.

        // my words may seems little complicated believe me this content will last long for years if you keep coming back and reading these notes. and you will understand as your brain shells breaks with achievements.

        // if we want to set position we can do it this way.

        obstacle.transform.SetPosition(new Vector(x,y,z)); // give your x y z values points to be noted. if our object contain a RigidBody you can not move your object from transform unless the isKinematic property is true. if isKinematic is false you have to apply forces or you can temp make isKinematic true and change it's position then set it back to false.
    }
}
```

## Common Transform Methods

The `Transform` component in Unity is essential for manipulating objects in the scene. Here are some of the most common methods:

- **SetParent**: Sets the parent of the transform.
    ```c#
    transform.SetParent(newParent);
    ```

- **SetPosition**: Sets the position of the transform.
    ```c#
    transform.position = new Vector3(x, y, z);
    ```

- **Translate**: Moves the transform in the direction and distance of `translation`.
    ```c#
    transform.Translate(Vector3.forward * Time.deltaTime);
    ```

- **Rotate**: Rotates the transform about the specified axis by the specified degrees.
    ```c#
    transform.Rotate(Vector3.up, 90);
    ```

- **LookAt**: Rotates the transform so the forward vector points at `target`'s current position.
    ```c#
    transform.LookAt(target);
    ```

- **TransformDirection**: Transforms `direction` from local space to world space.
    ```c#
    Vector3 worldDirection = transform.TransformDirection(localDirection);
    ```

- **TransformPoint**: Transforms `position` from local space to world space.
    ```c#
    Vector3 worldPosition = transform.TransformPoint(localPosition);
    ```

- **InverseTransformPoint**: Transforms `position` from world space to local space.
    ```c#
    Vector3 localPosition = transform.InverseTransformPoint(worldPosition);
    ```

These methods are fundamental for manipulating game objects in Unity and are frequently used in game development.


## Fetching Components

This section covers various methods available in Unity's `GameObject` class for fetching components:

- **GetComponent**: Retrieves a component of the specified type from the GameObject itself.
    ```c#
    Rigidbody rb = gameObject.GetComponent<Rigidbody>();
    ```
    - **Note**: This method only looks for the component in the GameObject itself.

- **GetComponents**: Retrieves all components of the specified type from the GameObject itself.
    ```c#
    Rigidbody[] rbs = gameObject.GetComponents<Rigidbody>();
    ```
    - **Note**: This method only looks for the components in the GameObject itself.

- **GetComponentInChildren**: Retrieves a component of the specified type from the GameObject or any of its children.
    ```c#
    Rigidbody rb = gameObject.GetComponentInChildren<Rigidbody>();
    ```
    - **Note**: This method looks for the component in the GameObject, its children, and children's children.

- **GetComponentsInChildren**: Retrieves all components of the specified type from the GameObject and its children.
    ```c#
    Rigidbody[] rbs = gameObject.GetComponentsInChildren<Rigidbody>();
    ```
    - **Note**: This method looks for the components in the GameObject, its children, and children's children.

- **GetComponentInParent**: Retrieves a component of the specified type from the GameObject or any of its parents.
    ```c#
    Rigidbody rb = gameObject.GetComponentInParent<Rigidbody>();
    ```
    - **Note**: This method looks for the component in the GameObject and its immediate parent.

- **GetComponentsInParent**: Retrieves all components of the specified type from the GameObject and its parents.
    ```c#
    Rigidbody[] rbs = gameObject.GetComponentsInParent<Rigidbody>();
    ```
    - **Note**: This method looks for the components in the GameObject and its immediate parent.

These methods are essential for accessing and manipulating components attached to GameObjects in Unity.


## Finding A GameObject by a component.

### Finding a GameObject by a Component

In Unity, you can find GameObjects by their components using various methods. Here are some of the most common ones:
Note Here the following method are according to the latest unity 6 update. i will also list the method which will be removed in future by unity so when you will update to unity 6 you can have access to the following methods.

- **FindFirstObjectByType**: Finds the first active loaded object of the specified type.
```c#
    Rigidbody rb = FindFirstObjectByType<Rigidbody>();
    GameObject obj = rb.gameObject;
```
    - **Note**: This method searches through all active loaded objects in the scene and returns the first one it finds. It is not very efficient for large scenes.
    - A similar method `FindAnyObjectByType<Rigidbody>()`

- **FindObjectsByType**: Finds all active loaded objects of the specified type.
    ```c#
    Rigidbody[] rbs = FindObjectsByType<Rigidbody>();
    foreach (Rigidbody rb in rbs)
    {
        GameObject obj = rb.gameObject;
        // Do something with obj
    }
    ```
    - **Note**: This method returns an array of all active loaded objects of the specified type. It is also not very efficient for large scenes.

- **FindWithTag**: Finds a GameObject by its tag.
    ```c#
    GameObject obj = GameObject.FindWithTag("Player");
    Rigidbody rb = obj.GetComponent<Rigidbody>();
    ```
    - **Note**: This method is more efficient than `FindFirstObjectByType` and `FindObjectsByType` if you know the tag of the GameObject you are looking for.

- **FindGameObjectsWithTag**: Finds all GameObjects with the specified tag.
    ```c#
    GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");
    foreach (GameObject obj in objs)
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        // Do something with rb
    }
    ```
    - **Note**: This method returns an array of all GameObjects with the specified tag. It is more efficient than `FindObjectsByType` if you know the tag of the GameObjects you are looking for.

These methods are useful for finding GameObjects by their components in Unity and can help you manage and manipulate objects in your scene more effectively.

these are the deprecated methods you may still see them. but better to not use them stay updated.
- FindObjectOfType()
- FindObjectsOfType()
- FindObjectsOfTypeAll()



## IEnumerator or Unity Coroutines
It is the best a efficient where you need to implement a logic where you need to run few lines of code then do delay and then again runs few line of code. efficient for scene transitions and Count Down.
**important points to note about it** 
- it runs on the same thread as our game is running. and execute in sequential flow. 
- it needs `StartCoroutine()` method from MonoBehavior to start.
- don't use lot of coroutines at the same time it might take performance especially from same class file.

in below code example i have written an code example to enable player controls after a count down of 5 seconds.

```c#
public class CountDownTimer : MonoBehavior
{
    public PlayerControls playerControls; // reference to player controls Script or component which handle user input and movements
    public GameObject countDownPanel; // a ui panel where our count down text is. we can enable and disable this game object
    public TMP_Text countDownText; // text which will show our count down to player. a visual representation for player.

    public int countDown = 5f;

    private void Start()
    {
        // okay in here we will start a coroutine for countdown in our first frame of game. as we know our start method trigger at the first frame of our GameObject. right
        StartCoroutine(CountDownCoroutine(countDown));
    }


    private IEnumerator CountDownCoroutine(int delay)
    {
        // as we start count down we want our player to unable to move so we will disable the controls script
        playerControls.enabled = false;
        countDownPanel.SetActive(true);

        // now here we will run a for loop

        for(int i = delay; i >= 0; i--)
        {
            if(i == 0)
            {
                countDownText.text = "Started";
            }
            else
            {
                countDownText.text = $"Starting In {i}";
            }
            yield return new WaitForSeconds(1); // 1 value in here means 1 seconds
        }

        playerControls.enabled = true;
        countDownPanel.SetActive(false);

        yield return null;
    }
    
}
```

**DontDestoryOnLoad** this method doesn't destroy your GameObject while changing scene.

```c#
DontDestoryOnLoad(gameObject);
```
