# Pac-Trump VR

## User Stories

## What is Pac-Trump VR?

------

Pac-Trump VR is a virtual reality game, whereby you are being chased through a maze by multiple enemies who spawn at set intervals in the centre of a maze. Your goal is to collect all golf balls in the maze before your three lives have been expended - you will lose a life each time an enemy touches you and be teleported to another spot on the map.

------

## Gameplay instructions

You will need to keep your posture upright with your head pointed slightly downwards while the VR headset is running with the game in order to move - raising your head above a 180 degrees angle will cause your character to stop moving forward. Turning your point of rotation will cause you to rotate simultaneously within the game. Moving forward into the golf balls will increment your score, whereas moving into the enemy will cause your character to take damage to their health (you can take damage three times before returning back to the homescreen of the game).

------

## Prerequisites

You will need either the following:
..* Unity Hub
..* Unity 2019 2.4f1 or greater.
• An android (9.0 Pie or greater) or iOS device (12.4.1 or greater).
• A VR headset which supports your plugged-in device.
• Google Cardboard SDK.

-------

## Installing

For installation you can either download the game directly from the Play Store on android, or follow the instructions below:

1. Git clone this repo and save it on your desktop.
2. Open your latest version of Unity Hub and select the 'Add' button, add the cloned project to the Unity Hub menu and click the project to launch it in Unity.
3. Click File -> Build Settings -> select your desired platform (either android or iOS).
4. Click the scene folder within the main Assets tab in the project tab and drag and drop in the 'intro', 'PacTrump 2.1' and 'Victory' scenes into the hierarchy.
5. Click File -> Build Settings -> Add Open Scenes. This will add all the scenes needed for the game to your deployment.
6. Lastly, you can click File -> Build Settings -> Build And Run with your chosen device plugged in (while on developer mode). The app should load onto your device, and will self-deploy on the first build.

Developer Mode: If you do not know how to go into developer mode, on an android device you can check here: https://developer.android.com/studio/debug/dev-options

For iOS check here: https://www.techjunkie.com/how-to-enable-developer-mode-on-iphone-and-ipad-in-ios-12/

-------

## Additional iOS deployment instructions

iPhone deployment instructions:
1. in unity click on file > build settings . Select IOS platform and click switch platform. This will take quite a long time the first time.
2. Still on build settings, click player settings. Under XR settings, click VR supported , then click the plus button and add google cardboard.
3. Play the game in unity to make sure it still works
4. download Xcode  10.3 from https://developer.apple.com/download/more/
5.   open and install to applications, sign in with your Apple ID if asked
6. Plug iPhone into Mac and trust the computer if asked
7. Open Xcode
8. In your iPhone settings there should be a developer icon with a hammer now
9. in Xcode , click Xcode at the top then open preferences. Click accounts , + account and add your Apple ID.  Then click download manual profiles.
10.  Go back to unity build settings then click build and run. name it something you’ll remember and build it on the desktop (just in case to avoid git issues)
11. Xcode will open and start trying to build it. You will get an error and lots of warnings and it will say build failed. Click on the error and it should say unity iPhone requires a provisioning profile.
12. Click on unity iPhone in the left side bar so that it comes up in the main centre window of Xcode  and have a general heading. Click on the general heading and click automatically manage signing, then under team select your Apple ID.
13. Press the triangular play icon to rebuild . If successful it will ask you to unlock your iPhone.
14. In order to open your unity project on your iPhone, open settings > general settings >device management and authorise yourself.  You can now open your app
15. You will need to repeat steps 12-14 every time you build and run a new app on your iPhone.

-------

## Built With

•Unity 2019 2.4f1 - Game engine
•Blender - Building game graphics
•C# - Language for writing scripts
•Android Studio - Deployment to android devices
•XCODE - Deployment to iOS devices
•Google Cardboard SDK

------

![](TrumpForGithub.gif)

------

## Authors

•Khurram Mohammed (Kay)
•Kareem Zedan
•Ian Aquino
•James Palmer
•Marvin Matovu

------

## User stories


``` As a player
So that I can play
I would like to be able to start the game

As a player
So that I can play
I would like to be able to move around

As a player
So that I can win
I would like to be able to score points by acquiring golf balls

As a player
So that I can have fun
I would like Donald Trump to chase me

As a player
So that I can take a break
I would like to be able to pause the game

As a player
So that I can leave
I would like to be able to exit the game

As a player
So that I can enjoy my game more
I would like to have multiple lives

As a player
So that I don't get bored
I would like to hear music while I'm playing

As a player
So that I can keep track of my score
I would like to see my score displayed on the screen

As a player
So that I don't get bored
I would like to be able to increase difficulty

As a player
So that I can customize the game
I would like to have a setttings option

As a player
So that I can win
I would like to acquire all the golf balls

As a player
So that I can lose
I would like to Donald Trump to catch me
```

------
