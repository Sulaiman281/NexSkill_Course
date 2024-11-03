
## Unity Structs

In Unity, structs are value types that are used to represent small data structures. Unlike classes, structs are stored on the stack and are copied when passed around. This makes them more efficient for small data structures that do not require inheritance.

### Common Unity Structs

1. **Vector3**
    - Represents a 3D vector or point in space.
    - **Components:**
      - `x`: The x component of the vector.
      - `y`: The y component of the vector.
      - `z`: The z component of the vector.

    **Example:**
    ```csharp
    ```csharp
    Vector3 position = new Vector3(1.0f, 2.0f, 3.0f);
    position = new Vector3(4.0f, position.y, position.z); // Updating the x component
    Debug.Log(position);
    ```
    ```

2. **Vector2**
    - Represents a 2D vector or point in space.
    - **Components:**
      - `x`: The x component of the vector.
      - `y`: The y component of the vector.

    **Example:**
    ```csharp
    Vector2 position = new Vector2(1.0f, 2.0f);
    position.y = new Vector2(position.x, position.y+2.5f);
    Debug.Log(position);
    ```

3. **Quaternion**
    - Represents rotations.
    - **Components:**
      - `x`: The x component of the quaternion.
      - `y`: The y component of the quaternion.
      - `z`: The z component of the quaternion.
      - `w`: The w component of the quaternion.

    **Example:**
    ```csharp
    Quaternion rotation = Quaternion.Euler(0, 90, 0);
    rotation = Quaternion.Euler(0, rotation.y, 0.5f);
    Debug.Log(rotation);
    ```

4. **Color**
    - Represents colors.
    - **Components:**
      - `r`: The red component of the color.
      - `g`: The green component of the color.
      - `b`: The blue component of the color.
      - `a`: The alpha (transparency) component of the color.

    **Example:**
    ```csharp
    Color color = new Color(1.0f, 0.0f, 0.0f, 1.0f); // Red color
    color.g = 1.0f; // Updating the green component
    Debug.Log(color);
    ```

5. **Rect**
    - Represents a rectangle.
    - **Components:**
      - `x`: The x position of the rectangle.
      - `y`: The y position of the rectangle.
      - `width`: The width of the rectangle.
      - `height`: The height of the rectangle.

    **Example:**
    ```csharp
    Rect rect = new Rect(0, 0, 100, 50);
    rect.width = 200; // Updating the width
    Debug.Log(rect);
    ```

### Updating Structs

Structs in Unity can be updated by directly modifying their components. Since structs are value types, any modification creates a new copy of the struct.

**Example:**
```csharp
Vector3 position = new Vector3(1.0f, 2.0f, 3.0f);
position.x = 4.0f; // Updating the x component
Debug.Log(position); // Output: (4.0, 2.0, 3.0)
```

Understanding and using structs efficiently can help improve the performance and organization of your Unity projects.