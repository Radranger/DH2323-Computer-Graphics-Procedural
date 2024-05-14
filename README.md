# DH2323 Computer Graphics and Interaction
## Procedural Walking Animation - The Blog

This is our blog for the project. We discuss and update on our process from the initial idea to our final implementation. 

### 2024-05-05

[Detta är EFTER specifikationen blev klar. Här började vi göra research och spåna idéer på implementation för PWA]

Started doing research about Procedural Walking Animation (PWA) and brainstorming ideas for implementation. Everyone agreed in the end to make an implementation using Inverse Kinematics (IK) and Raycasting. Found a paper "[Procedural locomotion of multilegged characters in dynamic environments](https://onlinelibrary.wiley.com/doi/abs/10.1002/cav.1467?casa_token=L0yaDg2djtEAAAAA%3A_C3_S6ZbTOgz-1ITWVdgoP_Flx-zlLy-h_biQJN62jQtPJJIrwkndg4p33LVwVJ5cRW6bwAaWcOU2Gg)" which seemed very similar and relevant to our own goal.

### 2024-05-07

[gjort inverse kinematics, lite strul med GitHub commit men gick bra i slutändan]

Found a [four-legged spider model](https://assetstore.unity.com/packages/3d/characters/robots/spider-orange-181154#content) and used built-in Unity package "Animation Rigging" to implement IK. At the end of session, an early and very bare-bone implementation of IK works! 

test to see if links attachments to images/GIFs work on readme
![](https://github.com/Radranger/DH2323-Computer-Graphics-Procedural/blob/main/Images%20and%20GIFs/github%20GIF%20test.gif)

### 2024-05-09

[mall för rapport (men detta ska nog inte tas med), föröker skapa kollision med marknivån]

Early 

Anteckning Luca: We started the meeting with a quick summary of the previous meeting where we discussed how we imported the model with all its components. The movement of the limbs was still not correctly implemented so we tried to use a video guide as well as resources that we found on the internet. Getting the tip of the legs to be fixed to the ground was quite complicated at first and we had to look up guides that would explain how to do this. We then created a C#-script to experiment with some ideas that we had. For example we tried to use the function OnCollisionEnter with a boolean variable ”hasCollided” as well as the method ”FreezePosition”. Sadly we were not able to implement the movement of the limbs through this approach so we continued looking for guides that could help us with this step.

### 2024-05-10

Anteckning Alex: Step 3 in the process, creating a target point that’s an empty game object attached to the body, this empty game object will be named ”Body target”. We’ll have a new script that raycasts it to the ground. When it has moved forward a certain distance from its current position, the legs should update to a new standard position based on the body’s position. Currently attempting at implementing four tagers, one for each leg, instead of having one whole target for all four legs. When doing the new target game object to implement a step, we started with one such target, and implemented so that one leg could take a step, and then duplicate it to work on all four. 

### 2024-05-12

Found more academic paper "Evaluating Emotive Character Animations Created with Procedural Animation" which we found relevant to the project. The peport has gone through extensive writing of things we currently have work on such as introduction, related work, current implementation at the current stage and explanation of theories. 

### 2024-05-13

Managed to make the spider legs react appropriately to uneven terrain. Also worked a little on lerp by attempting to have the steps make a smooth animation when transitioning from current target to new target.

### 2024-05-14

