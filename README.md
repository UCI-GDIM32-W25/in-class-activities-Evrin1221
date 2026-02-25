# GDIM32 In Class Activities
## W1

### Activity 1

One piece of advice: Playtest your build not just on the engine

### Activity 2


Q1:10

Q2:2

Q3:Prints hello world to the console every frame

Q4:Monobehavior

Q5:Prints "x=10" when the game starts

Q6:They're called parameters. It's basically the piece of data passed to the method for it to do its function

Q7:You need to use the variable name for the transform. this code is using the datatype itself(?) which is incorrect

Q8:_playerTransform


### Activity 3


https://docs.google.com/document/d/1MR5s2MD1t6kFIP1PlwggtskA_hNJPmX335sJPT-4Uuw/edit?tab=t.0 



## W2

### Activity 1

![alt text](<Screenshot 2026-01-13 173728.png>)

### Activity 2

[Progress on MG2](https://github.com/UCI-GDIM32-W25/mg2-oop-review-Evrin1221/commit/bd1e6c21900eb446c6d0fbc1c813f3f2a43521d2)

I set up the player and coins and their components. I started a little on the player movement code and I made the canvas for the UI

## W3

### Activity 1 & 2

Romarick Anderson

### Activity 3

![alt text](<Screenshot 2026-01-20 180036.png>)

## W4

### Activity 0
partner: Romarick Anderson

### Activity 1

Adding more locators makes it run much slower. probably because all the information is being sent multiple times


### Activity 2


![alt text](<Screenshot 2026-01-27 183402.png>)


### Activity 3

[Progress on MG4](https://github.com/Evrin1221/MG4/commit/d8abf3e29b11a7188c097fefad9b2b85db8bcf95)

## W5

### Activity 1


We think the Ibreakable is useful, but we also think it'd be better to have a class that calculates the damage for each object because it feels redundant to have to do it for every object. 

### Activity 2


Model is the data, the view is the UI and the characters, and the controller is the code that modifies the damage

### Activity 3

#### Scenario 1

make prefabs with scriptable objects on them (can add sprites and stuff too). Scriptable object data can have start time, note type etc. 

#### Scenario 2

The model is the data regarding each player, such as their account, which character they have selected, which side they're on. View would be what we can see, such as the item we have equiped, the bar that shows the items available to the player, the bar that shows who's alive and who's dead. The controller would be the code that handles interactions, for example dealing damage, item interactions with each other, and player movement

#### Scenario 3

State of growth of the plant, state of the action the player is doing can be handled using state machines.

### Activity 4

Attendance: Romarick Anderson, Ransom Liu, Evrin Lee

[Project proposal](https://docs.google.com/document/d/1yaFfMOREKQ-uBypP_ClrG3IaEjA-R7tuW3AvkSeLdno/edit?tab=t.0#heading=h.y4j3q551ojs1) 

## W6

### Talk: Narrative writing for games Speaker: Corey Lanham

#### Notes:

- One of the best ways to get a job in narrative writing for games is to start as a different position on a development team, and interact with the writers as much as possible
- Creative writing and writing for games is very different (at least a lot more than I originally thought)
- writers need to communicate a LOT with the designers
- narrative writers are NOT the director - they have less power in deciding the narrative direction of the game than you'd think


### Talk: Technical artist's role in games Speaker: Stephen Coan

#### Notes:

- Technical artists basically make it easier for artists to get their visions/creations into a game
- a key skill you need to have is the ability to learn and jump into challenges
- he also showed us how he identified a performance issue in a 3d scene where someone had imported a scaled down version of a different scene and it was completely hidden from sight
- a good place to start to get into technical art is to learn blender (specifically shaders)
- a good way to build a portfolio for this role is to just try to recreate cool art related things (that involve coding ofc)


## W7

### Activity 1

#### Notes:

- Raycast used to see line of sight, and how far the subject can see, and if its line of sight is being obstructed
- Can use a FSM to code the duck's actions depending on its state (wandering and pursuing)
- Vectors are used to determine the line of sight
- A Raycast is basically a line drawn in the scene and seeing if it hit something (in this case it will only go as far as the line of sight max distance)
    - (Gizmoz.DrawRay)
- Raycast returns a boolean (true if it hit something)
- Sphere casts can be used to see if there's something obstructing the subject's path
    - Can use if you want npcs to avoid obstacles
    - Can focus on an area within the sphere rather than a straight line/ray (raycast might not be very accurate if obstacles are much taller or shorter)
- Casting can be more useful for debugging than debug.log



### Activity 2

Attendance: Romarick Anderson, Evrin Lee

### Activity 3

![alt text](<Screenshot 2026-02-17 174608.png>)

### Activity 4

[Link to Trello board](https://trello.com/invite/b/69951aa57a19f640467fab13/ATTIcf21601f209af46d29547e2c5f8dd86c73678BD7/gdim-32-final)

### Activity 5
[Work done today](https://github.com/random0624/GDIM32-Final/commit/6349b70166a95c4aba69a05ace51f64f1b8fd1b4)

I found an asset for the lion npcs, and added a plane that should determine the size for the entire arena. 

## W8

### Activity 1

- the shader must match the project pipeline !!
- post processing= shaders that affect look of entire screen
- use post process volume component in a post processing game object
    - has cool stuff like colour grading settings
- need to download post processing package

### Activity 2

Attendance: Ransom Liu, Romarick Anderson, Evrin Lee

### Activity 3

Playtesting goal: everything we did for this week functions (movement, lion chasing, and can click on door to interact with it(it will disappear))

Playtesting captain: Evrin

Playtesting notes:
- whys the font suddenly big

### Activity 4

### Activity 5
