# in-class-activities
## Devlogs
### W1
Hello world!

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

1. r, g, and b variables are float because they are not integers but numbers with deicmal points.
2. _bounce variable is an int because the unit we count is integers without decial points.
3. There wasn't a semincolon at the end of the line.

### W3
Table 1 - The input should be float and the return type should be boolean.

### w4
Table 1
Line 5: _moveSpeed is a member variable, and the type is float. Private means the variable is only accessible inside this class. [SerializeField] tells unity to serialize the private  field so it appears in the inspector.
Line 22: translatioin is local variable, and the type is float. Input is a class. GetAxis("Vertical") is calling a method. Time.deltaTime is a float.
Line 25: transform is a component.Translate(0, 0, translation) is calling a method on that component. The method parameters are x = 0, y = 0, z = translation.
1. I added Rigidbodies to cat and soccerball since they need collision physically, and I check isTrigger on goal because the soccer ball needs to pass through it without collision.
2. I added Rigidbody to goal at first because I thought if the soccerball hits the goal, I thought the ball should collide with the goal but it turned out that I just need isTrigger on the goal.

### w5
How do I move an object forward regardless of its world orientation?
Use its local forward vector times speed and Time.deltaTime.

Me and my pair planned to create the DeerW5 by setting it as a Transform variable which is a target. We made a class by adding MonoBehaviour to attach as a component. Then, we created private NavMeshAgent and we initiate it with getComponent method. Lastly we set destination using the target object.

### w6
I did unity engine and this is the link to google doc: [link](https://docs.google.com/document/d/1_oQY0junK3b37PITxN8uItEEPKJGHvci47NArvtUxiQ/edit?usp=sharing)

I need two member variables: public float speed and private bool isChasing.
I need methods like public void StopChasing() and public void StartChasing(); Update().
It flips isChasing.


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
