In C#, you can perform a variety of arithmetic operations on numeric data types (like `int`, `float`, `double`, etc.), but some operations are restricted depending on the data types or how operators are overloaded.

---

### **Arithmetic Operations You Can Perform in C#**

#### **1. Basic Arithmetic Operators**
- **Addition (`+`)**: Adds two numbers.
  ```csharp
  int sum = 5 + 3; // result: 8
  ```

- **Subtraction (`-`)**: Subtracts the second number from the first.
  ```csharp
  int difference = 5 - 3; // result: 2
  ```

- **Multiplication (`*`)**: Multiplies two numbers.
  ```csharp
  int product = 5 * 3; // result: 15
  ```

- **Division (`/`)**: Divides the first number by the second.
  - For integer types, division results in an integer, discarding any remainder.
  ```csharp
  int quotient = 10 / 3; // result: 3
  double quotient = 10.0 / 3.0; // result: 3.333...
  ```

- **Modulus (`%`)**: Finds the remainder after division.
  ```csharp
  int remainder = 10 % 3; // result: 1
  ```

#### **2. Compound Assignment Operators**
- **Addition Assignment (`+=`)**: Adds and assigns the result to the variable.
  ```csharp
  int x = 5;
  x += 3; // x is now 8
  ```

- **Subtraction Assignment (`-=`)**: Subtracts and assigns the result.
  ```csharp
  int x = 5;
  x -= 3; // x is now 2
  ```

- **Multiplication Assignment (`*=`)**: Multiplies and assigns the result.
  ```csharp
  int x = 5;
  x *= 3; // x is now 15
  ```

- **Division Assignment (`/=`)**: Divides and assigns the result.
  ```csharp
  int x = 10;
  x /= 2; // x is now 5
  ```

- **Modulus Assignment (`%=`)**: Finds the modulus and assigns the result.
  ```csharp
  int x = 10;
  x %= 3; // x is now 1
  ```

#### **3. Increment and Decrement Operators**
- **Increment (`++`)**: Increases an integer by 1.
  ```csharp
  int x = 5;
  x++; // x is now 6
  ```

- **Decrement (`--`)**: Decreases an integer by 1.
  ```csharp
  int x = 5;
  x--; // x is now 4
  ```

---

### **Arithmetic Operations You Cannot Perform in C#**

#### **1. Division by Zero**
- Dividing by zero with integer types throws a `DivideByZeroException`.
  ```csharp
  int result = 10 / 0; // Throws DivideByZeroException
  ```

- For floating-point types (`float`, `double`), dividing by zero results in `Infinity` or `NaN` (Not a Number).
  ```csharp
  double result = 10.0 / 0.0; // Result: Infinity
  ```

#### **2. Modulus with Non-Numeric Types**
- Modulus operations (`%`) cannot be used with non-numeric types or complex types directly (e.g., strings or objects).

#### **3. Using Arithmetic Operators on Boolean Types**
- Arithmetic operators cannot be directly used with Boolean values (`true` and `false`) as they are not numeric.

#### **4. Unsupported Operations for Strings with Arithmetic Operators**
- C# does not support subtraction (`-`), multiplication (`*`), division (`/`), or modulus (`%`) directly on `string` data types, though you can use `+` to concatenate strings.

#### **5. Performing Arithmetic Operations on Nullable Types without Handling Null**
- Arithmetic operations on nullable types (like `int?` or `double?`) throw an error if a value is `null`, unless you check for null beforehand.



# Tasks
1. Calculate the Area Of a Circle
   - Write a program to calculate the area of a circle given its radius. use the formula `Area = π * radius^2`  Use `Math.PI`

2. Convert this `1698512400000` Millisecond value into hours, minutes and seconds.
   - 1000 Milliseconds are in one seconds. use simple arithmetic to convert and do Debug.Log inside Awake method.
3. Calculate the Sum of inside the loop and find the average.
```c#
public class Average : MonoBehavior
{
    public void Start()
    {
        int[] numbers = new [] {5,9,8,2};
        int sum;
        for(int i = 0; i < 5; i++;)
        {
            // calculate here.
        }
        // Debug.Log(average); output your average.
    }
}
```

4. Swap Two Numbers. in below example swap the number of a into b and b into a. 
```c#
public class SwapNumber : MonoBehavior
{
    public void Start()
    {
        int a = 10;
        int b = 15;

        Debug.Log("a = "+a);
        Debug.Log("b = "+b);
    }
}
```

5. Check Divisibility by a number.
```c#
public class Divisibility : MonoBehavior
{
    public void Start()
    {
        int num = 10;
        int divider = 3;

        // write here a condition to check if number can be divide by divider value? output the Debug.Log("Divisible"); if can otherwise. Debug.Log("Not Divisible");
    }
}
```

6. Create A Canvas UI Add 2 Input Fields, add 1 button, and 1 text for the output log.
```c#
using TMPro; // when we use TextMesh Pro components we use this import at the top.

public class Sum : MonoBehavior
{
    public TMP_InputField inputA;
    public TMP_InputField inputB;
    public TMP_Text output;

    public void Sum()
    {
        int valueA = int.Parse(inputA.text);
        int valueB = int.Parse(inputB.text);

        // calculate the results.

        // show results into output text.
        output.text = "RESULTS: ";
    }
}
```

7. Calculate the Distance Between the target and the player object.
   - use third person player.
   - create a canvas and place a text object for the output.
   - here is how we calculate the distance 
    ```c#
    Vector3 pointA = new Vector3(1, 2, 3);
    Vector3 pointB = new Vector3(4, 6, 8);
    float distance = Vector3.Distance(pointA, pointB);
    Debug.Log("Distance: " + distance);
    ```
   - we will calculate the distance between the player and any our 3D object you can pick from the scene.
```c#
using TMPro;
public class Distance : MonoBehavior
{
    public Transform target;
    public Transform player;

    public TMP_Text output;

    public void Start()
    {

    }

    public void Update()
    {
        // calculate the distance between objects and show the results in output text.
    }
}
```

8. Normalize a Vector.
put the following code into Start Method to see the output 
```c#
Vector3 position = new Vector3(3, 4, 5);
Vector3 direction = position.normalized;
Debug.Log("Normalized Direction: " + direction);
```

9. Lerp between Two Position
create a simple sphere and create 2 empty objects call them point and attach this script to a ball.
```c#
public class BallLerpMotion : MonoBehavior
{
    public Transform pointA;
    public Transform pointB;
    public float lerpTime = 0.5f;
    private float t = 0;

    void Update()
    {
        t += Time.deltaTime / lerpTime;
        transform.position = Vector3.Lerp(pointA.position, pointB.position, t);
        if (t > 1) t = 0; // Reset for looping effect
    }
}
```
10. Randomize the User Position On Space Key Input
- use third person and randomize it's position from X and Z not the Y.
- unity Random.Range takes a minimum value and maximum value and generate value between minimum and maximum.
```c#
public class Randomize : MonoBehavior
{
    public float randomRange = 50;
    public Transform playerTrans;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            float rand = Random.Range(-randomRange, randomRange);

            // playerTrans.position = new Vector(x,y,z);
        }
    }
}
```