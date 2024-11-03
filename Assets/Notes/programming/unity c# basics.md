# we will understand the following content today.
- **C# Classes and Methods**
- **Unity Common Custom Data Types**
- **Common Methods of String and Unity Custom Types.**

## Unity C# Classes and Methods

### Classes

In C#, a class is a blueprint for creating objects. It defines properties, methods, and events. Classes are used to encapsulate data and functionality together.

**Syntax:**
```csharp
public class ClassName
{
    // Fields
    private int field;

    // Properties
    public int Property { get; set; }

    // Constructor
    public ClassName()
    {
        // Initialization code
    }

    // Methods
    public void MethodName()
    {
        // Method code
    }
}
```

**Example:**
```csharp
public class Player
{
    // Fields
    private string playerName;
    private int playerScore;

    // Properties
    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerScore
    {
        get { return playerScore; }
        set { playerScore = value; }
    }

    // Constructor
    public Player(string name, int score)
    {
        playerName = name;
        playerScore = score;
    }

    // Methods
    public void DisplayPlayerInfo()
    {
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Score: " + playerScore);
    }
}
```

### Methods

Methods are functions defined within a class that perform actions. They can take parameters and return values.

**Syntax:**
```csharp
public returnType MethodName(parameterList)
{
    // Method code
    return value;
}
```

**Example:**
```csharp
public class MathOperations
{
    // Method with no parameters and no return value
    public void PrintMessage()
    {
        Debug.Log("Hello, Unity!");
    }

    // Method with parameters and a return value
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method with a parameter and no return value
    public void PrintNumber(int number)
    {
        Debug.Log("Number: " + number);
    }
}
```

### Types of Methods

1. **Instance Methods:**
   - Belong to an instance of the class.
   - Require an object of the class to be called.

   **Example:**
   ```csharp
   Player player = new Player("John", 100);
   player.DisplayPlayerInfo();
   ```

2. **Static Methods:**
   - Belong to the class itself.
   - Can be called without creating an object of the class.

   **Example:**
   ```csharp
   public class Utility
   {
       public static void PrintMessage(string message)
       {
           Debug.Log(message);
       }
   }

   Utility.PrintMessage("Hello, Unity!");
   ```

Understanding classes and methods is fundamental to object-oriented programming in Unity C#. They allow you to create reusable and modular code, making your projects more organized and maintainable.


## Unity Custom Data Types
Custom Data Types means that unity has created their own c# classes and those classes can have their own fields and methods which we can use to get their respective functionality. all the components of the unity are unity custom data types. like

- Transform
- Rigidbody
- Canvas
- Camera

you can see unity has the many components and we can also create our own.
we can call there methods and their fields or properties. just like in `Transform` we can change position, rotate it and scale the game object. 
and check few common methods below.

### Transform Methods 
- `Transform.Translate(Vector3 translation)`: Moves the transform in the direction and distance of `translation`.
- `Transform.Rotate(Vector3 eulerAngles)`: Rotates the transform about the `eulerAngles`.
- `Transform.LookAt(Transform target)`: Rotates the transform to look at the `target`.
- `Transform.position`: Gets or sets the position of the transform in world space.

## Rigidbody
as we know that rigidbody can be used to add physics in our object. we want to add gravity force and any other force we can add this component in our rigidbody.

### Rigidbody Methods
- `Rigidbody.AddForce(Vector3 force)`: Applies a force to the Rigidbody, causing it to move.
- `Rigidbody.AddTorque(Vector3 torque)`: Applies a torque to the Rigidbody, causing it to rotate.
- `Rigidbody.MovePosition(Vector3 position)`: Moves the Rigidbody to the specified position.
- `Rigidbody.MoveRotation(Quaternion rot)`: Rotates the Rigidbody to the specified rotation.
- `Rigidbody.velocity`: Gets or sets the velocity of the Rigidbody.
- `Rigidbody.angularVelocity`: Gets or sets the angular velocity of the Rigidbody.
- `Rigidbody.isKinematic`: Gets or sets whether the Rigidbody is kinematic.
- `Rigidbody.mass`: Gets or sets the mass of the Rigidbody.
- `Rigidbody.drag`: Gets or sets the drag of the Rigidbody.
- `Rigidbody.angularDrag`: Gets or sets the angular drag of the Rigidbody.


## Struct Type
### Vector3
Represents a 3D vector or point in space.

**Properties:**
- `x`: The x component of the vector.
- `y`: The y component of the vector.
- `z`: The z component of the vector.

**Common Methods:**
- `Vector3.Lerp(Vector3 a, Vector3 b, float t)`: Linearly interpolates between two vectors.
- `Vector3.Cross(Vector3 lhs, Vector3 rhs)`: Returns the cross product of two vectors.
- `Vector3.Dot(Vector3 lhs, Vector3 rhs)`: Returns the dot product of two vectors.
- `Vector3.Normalize(Vector3 value)`: Returns the normalized version of the vector.

### Vector2
Represents a 2D vector or point in space.

**Properties:**
- `x`: The x component of the vector.
- `y`: The y component of the vector.

**Common Methods:**
- `Vector2.Lerp(Vector2 a, Vector2 b, float t)`: Linearly interpolates between two vectors.
- `Vector2.Perpendicular(Vector2 inDirection)`: Returns a vector perpendicular to the given vector.
- `Vector2.Dot(Vector2 lhs, Vector2 rhs)`: Returns the dot product of two vectors.
- `Vector2.Normalize(Vector2 value)`: Returns the normalized version of the vector.

### Quaternion
Represents rotations.

**Properties:**
- `x`: The x component of the quaternion.
- `y`: The y component of the quaternion.
- `z`: The z component of the quaternion.
- `w`: The w component of the quaternion.

**Common Methods:**
- `Quaternion.Euler(float x, float y, float z)`: Creates a quaternion from Euler angles.
- `Quaternion.Lerp(Quaternion a, Quaternion b, float t)`: Linearly interpolates between two quaternions.
- `Quaternion.Slerp(Quaternion a, Quaternion b, float t)`: Spherically interpolates between two quaternions.
- `Quaternion.Inverse(Quaternion rotation)`: Returns the inverse of the given quaternion.

## Common Methods

### Random Methods
- `Random.Range(int min, int max)`: Returns a random integer number between `min` [inclusive] and `max` [exclusive].
- `Random.Range(float min, float max)`: Returns a random float number between `min` [inclusive] and `max` [inclusive].
- `Random.value`: Returns a random float number between 0.0 and 1.0.

### Vector Methods
- `Vector3.Distance(Vector3 a, Vector3 b)`: Returns the distance between two vectors.
- `Vector3.Magnitude(Vector3 vector)`: Returns the length of the vector.
- `Vector3.Scale(Vector3 a, Vector3 b)`: Multiplies two vectors component-wise.
- `Vector3.Reflect(Vector3 inDirection, Vector3 inNormal)`: Reflects a vector off the plane defined by a normal.

These are some of the fundamental data types and methods used in Unity C# programming. Understanding these will help you manipulate objects and create complex behaviors in your Unity projects.

## Common methods from strings data type.


### String Methods
- `string.Substring(int startIndex, int length)`: Retrieves a substring from this instance.
- `string.Equals(string value)`: Determines whether this instance and another specified string object have the same value.
```csharp
//this method compare to string and return true or false base on the values if they match or not match. when comparing two strings they will also check the upper case and lower case.
if(string.Equals("Syed", "Syed"))  // these two values are totally same and their upper case or lower case are also the same. so it will return true
if(string.Equals("SyeD", "SYED")) // it will return false. as their case does not match.

```
- `string.ToLower()`: Returns a copy of this string converted to lowercase.
- `string.ToUpper()`: Returns a copy of this string converted to uppercase.
- `string.Contains(string value)`: Returns a value indicating whether a specified substring occurs within this string.
```csharp
string playerName = "Suleiman";
if(playerName.Contains("man")) // this string method check if the sequence match in the name.
{
    actor.PlayDialog("hmmm. Man Mum Min");
}
```
- `string.Replace(string oldValue, string newValue)`: Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
- `string.Split(char separator)`: Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.
- `string.Trim()`: Removes all leading and trailing white-space characters from the current string.
- `string.Length`: Gets the number of characters in the current string.

These methods are commonly used for string manipulation in C# and can be very useful in various programming scenarios.



## Casting in C#

Casting is the process of converting a variable from one type to another. There are two types of casting in C#: implicit and explicit.

### Implicit Casting
Implicit casting is done automatically when converting a smaller type to a larger type. There is no data loss, and no special syntax is required.

**Examples:**
- `int` to `float`
- `char` to `int`
- `float` to `double`


```csharp
int myInt = 9;
double myDouble = myInt; // Implicit casting: int to double

char myChar = 'A';
int myCharToInt = myChar; // Implicit casting: char to int

float myFloat = myInt; // Implicit casting: int to float
```


### Explicit Casting
Explicit casting must be done manually when converting a larger type to a smaller type or when there is a potential for data loss. This requires a cast operator.

**Examples:**
- `double` to `float`
- `float` to `int`
- `int` to `char`


```csharp
double myDouble = 9.78;
int myInt = (int)myDouble; // Explicit casting: double to int

float myFloat = 9.78f;
int myFloatToInt = (int)myFloat; // Explicit casting: float to int

int myInt = 65;
char myIntToChar = (char)myInt; // Explicit casting: int to char
```


### Casting Rules
1. **Implicit Casting:**
    - No special syntax required.
    - No data loss.
    - Smaller type to larger type.

2. **Explicit Casting:**
    - Requires cast operator.
    - Potential data loss.
    - Larger type to smaller type.

### Castable Data Types
- **Implicitly Castable:**
  - `byte` to `short`, `int`, `long`, `float`, `double`
  - `short` to `int`, `long`, `float`, `double`
  - `int` to `long`, `float`, `double`
  - `long` to `float`, `double`
  - `float` to `double`
  - `char` to `int`



```csharp
byte myByte = 25;
short myShort = myByte; // Implicit casting: byte to short

short myShort = 100;
int myInt = myShort; // Implicit casting: short to int

int myInt = 1000;
long myLong = myInt; // Implicit casting: int to long

long myLong = 10000L;
float myFloat = myLong; // Implicit casting: long to float

float myFloat = 10.5f;
double myDouble = myFloat; // Implicit casting: float to double

char myChar = 'B';
int myCharToInt = myChar; // Implicit casting: char to int
```

- **Explicitly Castable:**
  - `double` to `float`, `long`, `int`, `short`, `byte`
  - `float` to `long`, `int`, `short`, `byte`
  - `long` to `int`, `short`, `byte`
  - `int` to `short`, `byte`
  - `short` to `byte`
  - `int` to `char`


```csharp
double myDouble = 9.99;
float myFloat = (float)myDouble; // Explicit casting: double to float

float myFloat = 9.99f;
long myLong = (long)myFloat; // Explicit casting: float to long

long myLong = 10000L;
int myInt = (int)myLong; // Explicit casting: long to int

int myInt = 1000;
short myShort = (short)myInt; // Explicit casting: int to short

short myShort = 100;
byte myByte = (byte)myShort; // Explicit casting: short to byte

int myInt = 65;
char myChar = (char)myInt; // Explicit casting: int to char
```

### Non-Castable Data Types
- Reference types to value types (without using conversion methods).
- Value types to reference types (without using conversion methods).
- Incompatible types (e.g., `string` to `int` without parsing).

Understanding these rules and types will help you avoid runtime errors and data loss when performing type conversions in C#.

```csharp
string myString = "123";
int myInt = int.Parse(myString); // Using conversion method: string to int

object myObject = 123;
int myInt = (int)myObject; // Using conversion method: object to int
```


## Quiz Questions

### Question 1
What is the output of the following code?

```csharp
string text = "Hello World";
string result = text.Substring(0, 5).ToUpper();
Debug.Log(result);
```

- A) `HELLO`
- B) `WORLD`
- C) `hello`
- D) `Hello`

### Question 2
What is the output of the following code?

```csharp
int score = 150;
string result = score >= 100 ? "Win" : "Lose";
Debug.Log(result);
```

- A) `Win`
- B) `Lose`
- C) `Draw`
- D) `Error`

### Question 3
What is the output of the following code?

```csharp
Vector3 playerPosition = new Vector3(10, 0, 5);
Vector3 checkpointPosition = new Vector3(10, 0, 10);
float distance = Vector3.Distance(playerPosition, checkpointPosition);
Debug.Log(distance);
```

- A) `5`
- B) `10`
- C) `15`
- D) `20`

### Question 4
What is the output of the following code?

```csharp
int lapsCompleted = 3;
int totalLaps = 5;
float progress = (float)lapsCompleted / totalLaps;
Debug.Log(progress);
```

- A) `0.6`
- B) `0.5`
- C) `0.75`
- D) `0.8`

### Question 5
What is the output of the following code?

```csharp
string playerName = "Player1";
string welcomeMessage = "Welcome, " + playerName + "!";
Debug.Log(welcomeMessage);
```

- A) `Welcome, Player1!`
- B) `Welcome, Player!`
- C) `Hello, Player1!`
- D) `Hello, Player!`

### Question 6
What is the output of the following code?

```csharp
Vector2 ballVelocity = new Vector2(3, 4);
Vector2 normalizedVelocity = ballVelocity.normalized;
Debug.Log(normalizedVelocity);
```

- A) `(0.6, 0.8)`
- B) `(0.8, 0.6)`
- C) `(3, 4)`
- D) `(4, 3)`
