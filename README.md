![alt text](<nexskill logo.webp>)
# Course Content

## [Chapter 1: Introduction to Game Engine and Unity Engine](#chapter-1)
- Game Engines—What Are They?
- The Unity Game Engine
- Installation and Configuration of UNITY (LTS and Support Systems)
- Introduction of Cross-Platform in Unity

## [Chapter 2: The Script Editor: Visual Studio Code](#chapter-2)
- Navigating the Unity Interface
    - Inspector
    - Scene Window
    - Game Window
    - Hierarchy
    - Project Setting Window
- Importing of Assets in UNITY
    - Brief Discussion on Extensions that Unity Supports
    - How Unity Changes Them into .asset Files
- Essential Unity Concepts
    - Game Objects and Components
    - Prefabs
    - Tags
    - Layers
    - Camera
- Creating Scene
    - The Hierarchy and Parent-Child Relationships

## Chapter 3: C# Scripting
- Scripts as Behaviors Components
- Awake and Start
- Update and Fixed Update
- Enabling and Disabling Components
- Activating Game Objects
- Translate and Rotate
- Look At
- Linear Interpolation
- Destroy
- GetButton and GetKey
- GetAxis
- OnMouseDown
- GetComponent
- Delta Time
- Instantiate
- Invoke

## Chapter 4: Advanced C# Scripting
- Statics
- Generics
- Extension Methods
- Lists and Dictionaries
- Coroutines
- Quaternions
- Delegates
- Attributes
- Events
- Scriptable Objects

## Chapter 5: Canvas System - UI
1. UI Canvas
2. UI RectTransform
3. UI Button
4. UI Image
5. UI Text
6. UI Events and Event Triggers
7. UI Slider

## Chapter 6: Physics
1. Colliders
2. Colliders as Triggers
3. Rigidbodies
4. Adding Physics Forces
5. Adding Physics Torque
6. Physics Materials
7. Physics Joints
8. Detecting Collisions with OnCollisionEnter
9. Raycasting

## Chapter 7: Animations
- The Animation View
- Animation Properties
- Animation Curves and Events
- The Animator Component
- The Animator Controller
- Animator Controller Layers
- Animator Scripting
- Blend Trees
- Animator Sub-state Machine Hierarchies

## Chapter 8: Ragdoll and Inverse Kinematics
- Apply IK on Humanoid Characters

## Chapter 9: Lighting and Rendering
- Lighting Overview
- Lights (All Types of Lights)
- Using Skyboxes
- The Standard Shader
- Materials
- Textures
- A Gentle Introduction to Shaders

## Chapter 10: Audio Setup
- Audio Listeners
- Audio Sources
- Optimized Way of Calling Sound in Game

## Chapter 11: Navigation Basics
1. Navigation Overview
2. NavMesh Baking
3. The NavMesh Agent
4. Off-mesh Links
5. NavMesh Obstacles

## Chapter 12: Systems Basics
- Particle System
- Event System
- Line Renderer
- Sprite Renderer
- Trail Renderer
- Editor Settings
- Build Settings
- Player Settings
- Scoring Systems using Pref Class, Scriptable Objects, JSON File

## Chapter 13: Third Party Plugins/Essential Packages
- Unity Standard Assets
- Stats and Profilers
- DOTweens
- Import Packages through UPM
- CineMachine

## Project
- Submit Project Proposal
- Start Work on It After Approval (Show Progress While Working)
- Project Submission


<!-- Chapter 1 Here Definitions -->
---

# Chapter 1 
### What is a Game Engine?
A **game engine** is a software framework designed to simplify and streamline the game development process. It provides developers with a suite of tools and features to create video games, handling various aspects such as graphics, physics, audio, artificial intelligence (AI), and user input¹².

### Key Components of a Game Engine:
1. **Graphics Engine**: Renders 2D or 3D visuals, textures, and animations.
2. **Physics Engine**: Simulates real-world physics, including collisions and gravity.
3. **Audio Engine**: Manages sound effects, music, and voiceovers.
4. **AI System**: Controls non-player characters (NPCs) and their behaviors.
5. **Input Management**: Handles user inputs from devices like keyboards, mice, and controllers¹².

### Ex Unity Game Engine?
**Unity** 
- Unity is one of the most popular game engines.
- It Supports Both 3D Games and as well as 2D Game Development.
- Unity Provide All the Necessary tools to Develop a Game. Such as
  - Unity Input System
  - Unity Canvas for UI and UX
  - Unity Has AI Agents 
  - Unity Support Multiple Rendering Solutions, Built In, Universal Renderer(URP), and High Definition Render Pipeline (HDRP).
  - Unity Create and Support Animations Clips and Control them with a Animator Controller.
  - Unity Provide An Amazing Physics Components Which Helps us to add realistic physics in the game.
    - example Colliders and RigidBody.
- Apart from All these amazing features Unity also provides Services To Monetize Your Game, Add Multiplayer, Create Lobbies, Cloud Data Storage, Vivox Voice Chat and Dedicate Server Hosting.
- Unity Support Cross-platform Deployment. Which Means Once You can Build Your Application on different Platforms such as Mobile, WebGL, VR and Desktop PC. by only doing slight dependencies changes. 

----

**[Download](https://unity.com/download) The Unity Hub**

Unity Hub is an Application provide by Unity To Handle Unity Installation of different versions and it also Manage Your Projects. It has built in Templates for different Platforms it also provide learning content.

Install any latest LTS (Long Term Supported) Version From Your Unity Hub. and make sure to check Android Dependencies To Include Them. as our focus will be on developing a Unity Mobile App.

------------------------------------------------
# Chapter 2
Let's Understand The Basics of Unity Editor!

First We Have Project Window
![project window](image.png)

Assets are our games files such as images, sound effects, our character sprites, animations clips, our c# scripts files. we import our files into our asset folders. and we can organize them. as we want like all the sound effects in audio folder, or all the c# scripts in our Script Folder.

Here are some Unity Facts

* when we import any of our asset unity create .meta file of our each asset file and in our meta file. it has some a unique id and import settings. and where we can see all those settings?

Select Any File and check our the **inspector window**
![inspector window](image-1.png)

any of our assets file or our game object. when we select it. the inspector shows all the Components and properties of that file. for the files we can see different settings and for the game objects we can see different components.

Now as we progress we will get use to it. but for now let's understand and if you want to see the settings we select the file and it shows the settings in the inspector window.



## Now Let's Understand the Scene.

![alt text](image-3.png)


Unity Scene is a place where we put all the stuff together our assets files, and create some cools game objects, design our game environment. it's like preparing a stage. let's take an example. you want to prepare an concert stage for your favorite singer to perform. but the twist is there are some haters who want to destroy the stage which you built so hard for an event. but we are going to create our Hero Cop! who will save the concert by arresting those haters who try to ruined the event of our favorite singer. Oh Wow! we just create a game story.

so we will gather all our game files. create our scene. now back to the topic. we know that we place all stuff together in our scene to prepare an stage right. but How we do it?


### Unity Hierarchy
![alt text](image-4.png)

Here we place all of our objects. our concert models, lights, and all the stuff. to prepare our stage.

we will cover following topics by creating the our game scene.

- Game Objects and Components
  - a game object can have multiple components and it can be identified by tag and name. it also has a layer
- Transform
  - Transform is a common component in every single game object which handles position, rotation and scaling.
- Child and Parent Positions
  - ![parent child](image-5.png) we place an object inside another object to make it's children and when child local position base 0 is equal to parent position so when we move the parent child move with it and also rotate, scale according to the parent transform attributes.
- Pivot Point
  - in 2D or 3D game object pivot position is where the object start from.
    - learn to create door to understand it better!
- Prefabs
  - if we want to create similar objects in multiple places. we create object object then create prefab of that object. we drag our gameobject from our scene and darg it into asset folder. we can create a prefabs folder and place our folder in it. so we can use that prefab instead of creating another object when we need it.
- Tags
  - We Assign the Tages to Identify an Object From our Scripts in Runtime.
- Layers
  - we group different object by assiging it layers.
    - layers can be used to identify rendering
      - ![alt text](image-6.png)
    - layers can be used for our physics interaction that this object interact with this or not.
      - ![alt text](image-7.png)
- Camera
  - Camera is our players eyes from he sees our game environment.
  - Unity Camera has some special features to render only what it sees. here is the list
    - Camera Projection
      - There is 2 type of projection Perspective and Orthographic
        - Perspective is used mostly in 3D games it memic our human eye to see the world as we get away from an object it get's looks more distance.
        - Orthographic is like you are looking at a blueprint of a house map
          - ![house blueprint](image-8.png)
          - this perspective is mostly used in 2D games.
    - Camera Rendering
      - Important once for now are
        - Post Processing
          - these are the effects which are applied to camera before it render the image to the screen.
            - we can set global effect mean to all over our world
            - we can set effects for specific areas.
            - and this checkbox in the camera tell it to apply these effects or not.
            - ![post processing](image-9.png)
        - Occlusion Culling
          - Object which are not under camera perspective should not render.
        - Culling Mask
          - We Select the Layers Here which we want our camera to render.
      - Leave the other Settings At Default You Will Understand them as you progress in your learning.
## Creating Scene
We Will Be Building A Simple Concert Stage Scene! Let's Learn To Import this Asset From Unity Asset Store.

### [Click Me](https://assetstore.unity.com/packages/3d/props/interior/spotlight-and-structure-141453) To Download an asset we will be using to create our scene.

our aim is to understand unity hierarchy and create a simple game scene.

Here are the Actors we are going to use. you will find them in your course material.

![alt text](image-10.png)


















