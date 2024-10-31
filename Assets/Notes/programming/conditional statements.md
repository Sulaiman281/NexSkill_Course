## Relational Operators in C#
- `==` Equal to.
- `!=` Not Equal to.
- `>` Greater.
- `<` Less.
- `>=` Greater And Equal
- `<=` Less and Equal
- `&&` And
- `||` OR

### **Conditional Statements in Urdu**

Conditional statements programming mein aik bohot hi ahem kirdar ada karti hain. Yeh hamen mukhtalif conditions ya shara'it ko check kar ke faislay karne mein madad deti hain. Matlab agar koi condition ya shart sahi ho, toh program ek specific kaam karega, aur agar woh ghalat ho toh doosra kaam karega. 

Unity mein, conditional statements ka istamaal bohot zyada hota hai, jese ke aik player ki health check karna, enemy ko move karna ya kisi object ko pick karna waghera. C# mein sabse common conditional statements `if`, `else if`, aur `else` hain. 

---

### **Conditional Statements Types**

1. **`if` Statement:**  
   `if` statement ka istamaal tab hota hai jab hum koi shart ya condition check karna chahte hain. Agar woh condition sahi hai, toh code ke andar jo likha hai woh execute hoga.

   **Example:**
   ```csharp
   if (playerHealth > 0)
   {
       Debug.Log("Player is alive.");
   }
   ```

2. **`else` Statement:**  
   `else` statement tab execute hota hai jab `if` statement mein jo condition hai woh ghalat ho jaye. 

   **Example:**
   ```csharp
   if (playerHealth > 0)
   {
       Debug.Log("Player is alive.");
   }
   else
   {
       Debug.Log("Player is dead.");
   }
   ```

3. **`else if` Statement:**  
   `else if` statement tab use hota hai jab humein ek se zyada conditions check karni hoti hain.

   **Example:**
   ```csharp
   if (playerScore >= 100)
   {
       Debug.Log("Player reached high score!");
   }
   else if (playerScore >= 50)
   {
       Debug.Log("Player reached medium score.");
   }
   else
   {
       Debug.Log("Player needs more points.");
   }
   ```

4. **`switch` Statement:**  
   `switch` statement tab use hota hai jab humare paas multiple specific cases hotay hain aur hum unmein se ek ko check karna chahte hain.

   **Example:**
   ```csharp
   int weaponType = 2;

   switch (weaponType)
   {
       case 1:
           Debug.Log("Player has a sword.");
           break;
       case 2:
           Debug.Log("Player has a bow.");
           break;
       case 3:
           Debug.Log("Player has a staff.");
           break;
       default:
           Debug.Log("No weapon selected.");
           break;
   }
   ```

---

### **10 Game Development Conditional Quiz Questions**

1. **Code:**  
   ```csharp
   int score = 150;
   if (score >= 100)
   {
       Debug.Log("Player unlocked new level!");
   }
   ```
   **Question:** Agar `score` ki value `150` hai, toh output kya hoga?
   - A) Player unlocked new level!
   - B) Player needs more points.
   - C) Player lost.
   - D) No output.

   **Answer:** A) Player unlocked new level!

---

2. **Code:**
   ```csharp
   int health = 0;
   if (health > 0)
   {
       Debug.Log("Player is alive.");
   }
   else
   {
       Debug.Log("Player is dead.");
   }
   ```
   **Question:** Agar `health` ki value `0` hai, toh output kya hoga?
   - A) Player is alive.
   - B) Player is dead.
   - C) Player is safe.
   - D) Game Over.

   **Answer:** B) Player is dead.

---

3. **Code:**
   ```csharp
   int coins = 50;
   if (coins >= 100)
   {
       Debug.Log("Player can buy a new weapon.");
   }
   else
   {
       Debug.Log("Not enough coins.");
   }
   ```
   **Question:** Agar `coins` ki value `50` hai, toh output kya hoga?
   - A) Player can buy a new weapon.
   - B) Not enough coins.
   - C) Player has a new weapon.
   - D) Invalid coins.

   **Answer:** B) Not enough coins.

---

4. **Code:**
   ```csharp
   string weapon = "sword";
   if (weapon == "bow")
   {
       Debug.Log("Player equipped a bow.");
   }
   else if (weapon == "sword")
   {
       Debug.Log("Player equipped a sword.");
   }
   ```
   **Question:** Agar `weapon` ki value `"sword"` hai, toh output kya hoga?
   - A) Player equipped a bow.
   - B) Player equipped a sword.
   - C) Player is unarmed.
   - D) No output.

   **Answer:** B) Player equipped a sword.

---

5. **Code:**
   ```csharp
   bool isGameOver = true;
   if (isGameOver)
   {
       Debug.Log("Game Over.");
   }
   else
   {
       Debug.Log("Continue Playing.");
   }
   ```
   **Question:** Agar `isGameOver` ki value `true` hai, toh output kya hoga?
   - A) Game Over.
   - B) Continue Playing.
   - C) Game Paused.
   - D) Restart Game.

   **Answer:** A) Game Over.

---

6. **Code:**
   ```csharp
   int enemyCount = 3;
   if (enemyCount >= 5)
   {
       Debug.Log("High threat level.");
   }
   else
   {
       Debug.Log("Low threat level.");
   }
   ```
   **Question:** Agar `enemyCount` ki value `3` hai, toh output kya hoga?
   - A) High threat level.
   - B) Low threat level.
   - C) Medium threat level.
   - D) No threat.

   **Answer:** B) Low threat level.

---

7. **Code:**
   ```csharp
   int timeLeft = 10;
   if (timeLeft < 5)
   {
       Debug.Log("Hurry up!");
   }
   else
   {
       Debug.Log("Plenty of time left.");
   }
   ```
   **Question:** Agar `timeLeft` ki value `10` hai, toh output kya hoga?
   - A) Hurry up!
   - B) Plenty of time left.
   - C) Time’s up!
   - D) Almost there.

   **Answer:** B) Plenty of time left.

---

8. **Code:**
   ```csharp
   string playerStatus = "winner";
   if (playerStatus == "winner")
   {
       Debug.Log("Congratulations!");
   }
   else
   {
       Debug.Log("Try again.");
   }
   ```
   **Question:** Agar `playerStatus` ki value `"winner"` hai, toh output kya hoga?
   - A) Congratulations!
   - B) Try again.
   - C) You lost.
   - D) Better luck next time.

   **Answer:** A) Congratulations!

---

9. **Code:**
   ```csharp
   int ammo = 0;
   if (ammo > 0)
   {
       Debug.Log("Ready to fire.");
   }
   else
   {
       Debug.Log("Out of ammo.");
   }
   ```
   **Question:** Agar `ammo` ki value `0` hai, toh output kya hoga?
   - A) Ready to fire.
   - B) Out of ammo.
   - C) Reload.
   - D) Ammo full.

   **Answer:** B) Out of ammo.

---

10. **Code:**
   ```csharp
   int score = 75;
   if (score >= 80)
   {
       Debug.Log("Excellent");
   }
   else if (score >= 50)
   {
       Debug.Log("Good job");
   }
   else
   {
       Debug.Log("Keep trying");
   }
   ```
   **Question:** Agar `score` ki value `75` hai, toh output kya hoga?
   - A) Excellent
   - B) Good job
   - C) Keep trying
   - D) No output

   **Answer:** B) Good job

---

### **Game Scenario Example**

Imagine a simple Unity game jahan player ko aik treasure chest milta hai, lekin us chest ko kholne ke liye player ke paas ek specific key honi chahiye. Agar player ke paas woh key hai toh chest khul jayegi aur us mein se coins milenge. Agar key nahi hai toh chest lock hi rahegi aur player ko ek message milega "Key required to open the chest."

**Code Example:**
```csharp
bool hasKey = true;

if (hasKey)
{
    Debug.Log("Chest opened! You received 100 coins.");
}
else
{
    Debug.Log("Key required to open the chest.");
}
```

Yeh chhota sa scenario Unity mein aik basic game mechanic ko samjhata hai, jahan condition ke sath ham player ke actions control karte hain.


hmne phely bhi conditional statement pr code likha tha.. jese wo hmare coin picker wali game.

jisme ham check kr rahy thy. k coin se collision hone wala object agar player hy to coin object ko Destroy kro aor Log message ham kr rahy thy.. agar apko yad ho ye code

```c#
using UnityEngine;

public class CoinPickable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ye unity k built in method hy k ham object ka tag compare kr rahy hy.. 
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin picked up!");
            PlaygroundManager.Instance.PickCoin();
            Destroy(gameObject);
        }
    }
}
```



