# DH2323 Computer Graphics and Interaction
## Procedural Walking Animation - The Blog

This is our blog for the project. We discuss and update on our process from the initial idea to our final implementation. 

### 2024-05-05

Started doing research about Procedural Walking Animation (PWA) and brainstorming ideas for implementation. Everyone agreed in the end to make an implementation using Inverse Kinematics (IK) and Raycasting. Found a paper "[Procedural locomotion of multilegged characters in dynamic environments](https://onlinelibrary.wiley.com/doi/abs/10.1002/cav.1467?casa_token=L0yaDg2djtEAAAAA%3A_C3_S6ZbTOgz-1ITWVdgoP_Flx-zlLy-h_biQJN62jQtPJJIrwkndg4p33LVwVJ5cRW6bwAaWcOU2Gg)" which seemed very similar and relevant to our own goal.

### 2024-05-07

Found a [four-legged spider model](https://assetstore.unity.com/packages/3d/characters/robots/spider-orange-181154#content) and used built-in Unity package "Animation Rigging" to implement IK. At the end of session, an early and very bare-bone implementation of IK works! It has very minor but distinctive limp movement so far. Apart from work, there was some GiHub commit issues with the repository but was later fixed. 

![](https://github.com/Radranger/DH2323-Computer-Graphics-Procedural/blob/main/Images%20and%20GIFs/github%20GIF%20test.gif)
![](https://github.com/Radranger/DH2323-Computer-Graphics-Procedural/blob/main/Images%20and%20GIFs/github%20GIF%20test2.gif)

### 2024-05-09

After some time trying to implement the rest of IK to the limbs without any particular success, video guides as well as resources online were used. Getting the tip of the legs to be fixed to the ground (collision detection) was quite complicated. A C#-script was also created to experiment with some ideas that could help making it work, for example trying to use the function OnCollisionEnter with a boolean variable ”hasCollided” as well as the method ”FreezePosition”. 

![](https://github.com/Radranger/DH2323-Computer-Graphics-Procedural/blob/main/Images%20and%20GIFs/github%20GIF%20test3.gif)

### 2024-05-10

Now tried creating a target point that’s an empty game object attached to the body, this empty game object was named ”Body target”. New script was written that raycasts the target to the ground (as inspired by the tank turret from Track B - Animation). Now that it has moved forward a certain distance from its current position, the legs should update to a new standard position based on the body’s position. Currently attempting at implementing four tagers, one for each leg, instead of having one whole target for all four legs. When doing the new target game object to implement a step, firstly one such raget was created, and then implemented so that one leg could take a step, to then finally duplicate it to work on all four.

![](https://github.com/Radranger/DH2323-Computer-Graphics-Procedural/blob/main/Images%20and%20GIFs/github%20GIF%20test4.gif)
![](https://github.com/Radranger/DH2323-Computer-Graphics-Procedural/blob/main/Images%20and%20GIFs/github%20GIF%20test5.gif)

### 2024-05-12

This day turned out to be an extensive writing session of the report. Wrote about the things that currently work in the implementation. Paragraphs such as introduction, related, work and theory have been filled in, with room for expansion. Also found one more academic paper ["Evaluating Emotive Character Animations Created with Procedural Animation"](https://link.springer.com/chapter/10.1007/978-3-642-04380-2_33) which we found to be relevant for the project.

### 2024-05-13

Managed to make the spider legs react appropriately to uneven terrain! As seen below, the left legs of the spider reacts appropriately in relation to the surface of the uneven terrain while the right legs continue as normal as no uneven terrain disrupts them. Afterwards, attempts were made at integrating lerp (linear interpilation) into the legs to have them make a smooth animation when transitioning from current target to new target (i.e. taking a step), but this part of the implementation has been difficult to work on in Unity. The body of the spider remains stationary. Continued writing on the report as well.

![](https://github.com/Radranger/DH2323-Computer-Graphics-Procedural/blob/main/Images%20and%20GIFs/github%20GIF%20test6.gif)

### 2024-05-15

